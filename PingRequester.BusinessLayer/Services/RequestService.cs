using PingRequester.Data.DataObjects;
using System.Diagnostics;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using PingRequester.Data;
using System.Text.RegularExpressions;

namespace PingRequester.BusinessLayer.Services
{
    /// <summary>
    /// RequestService class.
    /// </summary>
    public class RequestService
    {
        private string stdout;
        private int remainingRequests;
        private int remainingAttempts;
        private bool pingSent;
        private IConsoleService console;
        private Requester requester;
        private ProcessStartInfo psi;

        /// <summary>
        /// Default constructor of the RequestService class.
        /// </summary>
        /// <param name="requester"></param>
        public RequestService(Requester requester, IConsoleService console)
        {
            this.console = console;
            this.requester = requester;
            this.remainingRequests = requester.NumberOfPR;
            this.remainingAttempts = requester.Attempts;
            this.pingSent = false;
            
            this.psi = new ProcessStartInfo
            {
                FileName = "ping",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
        }

        public string Stdout { get; set; }

        /// <summary>
        /// Begins sending requests.
        /// </summary>
        /// <returns>Task</returns>
        public async Task BeginRequestingAsync()
        {
            while ((this.remainingRequests > 0 && this.remainingAttempts > 0) || requester.InfiniteLoop)
            {
                // Check if interruption request was created
                if (this.requester.StopSignal)
                {
                    console.LogWarning("Stop signal was detected.");
                    break;
                }
                // check if stop on success is active
                if (requester.StopWhenSuccess && requester.InfiniteLoop && this.pingSent)
                {
                    console.LogMessage("Pinging interrupted on successful request (\"Stop when success\" option is enabled).");
                    if (requester.Settings.AlertOnSuccess)
                        Notifications.ConnectionSuccessful(!requester.Settings.MakeSound);
                    break;
                }

                // Send request
                await SendRequest(this.requester.RequestRun);
                await Task.Delay(requester.RefreshRate * 1000);
            }
        }

        /// <summary>
        /// Sends single ping request.
        /// </summary>
        private async Task SendRequest(RequestRun requestRun)
        {
            // use IPv4; if not set, use hostname instead
            if (requestRun.IPv4 == null)
                this.psi.Arguments = $"-n 1 -l {requestRun.PacketSize} {requestRun.Hostname}";
            else
                this.psi.Arguments = $"-n 1 -l {requestRun.PacketSize} {requestRun.IPv4}";

            // send ping request
            using (Process? process = await Task.Run(() => Process.Start(this.psi)))
            {
                // set ping sent to failure
                this.pingSent = false;
                // read the whole output
                stdout = await process.StandardOutput.ReadToEndAsync();
                await process.WaitForExitAsync();

                if (stdout.StartsWith("Ping request could not find host"))
                {
                    string warning = "Ping request could not find host.";
                    if (!requester.InfiniteLoop)
                        warning += $"\nRemaining attempts: {this.remainingAttempts - 1}";
                    console.LogWarning(warning);
                    SetCounters();
                }
                else if (stdout.Contains("Request timed out"))
                {
                    console.LogWarning("Request timed out.", true);
                    SetCounters();
                }
                else
                {
                    this.pingSent = true;

                    // if success handle UI
                    SaveDataFromPingOutput(stdout, requester.RequestRun);
                    requester.OnRequestRunUpdated(requestRun);

                    string logMessage = $"Ping sent to {requestRun.Hostname} at {DateTime.Now}";
                    if (!requester.InfiniteLoop)
                        logMessage += $"\nRemaining requests: {this.remainingRequests - 1}";
                    console.LogInfo(logMessage);
                    this.remainingRequests--;
                }
            }
        }

        /// <summary>
        /// Set or decrease counters.
        /// </summary>
        private void SetCounters()
        {
            if (!requester.InfiniteLoop)
            {
                this.remainingAttempts--;

                if (requester.Mode == "Precise")
                {
                    console.LogInfo("Remaining requests reset, precise mode active.");
                    this.remainingRequests = requester.NumberOfPR;
                }
            }
        }

        /// <summary>
        /// Read from output data related with a packet.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="rr"></param>
        /// <returns>Packet instance</returns>
        private Packet ReadPacketFromOutput(string text, RequestRun rr)
        {
            Match packetValues;
            Packet packet;

            // localhost
            if (rr.IPv4 == "127.0.0.1")
            {
                packetValues = Regex.Match(text, @"time.(\d+)");
                packet = new Packet()
                {
                    Bytes = rr.PacketSize,
                    Time = Int32.Parse(packetValues.Groups[1].Value),
                    Ttl = 0
                };
            }
            else    // standard format of output
            {
                packetValues = Regex.Match(text, @"bytes=(\d+) time=(\d+)ms TTL=(\d+)");
                packet = new Packet()
                {
                    Bytes = Int32.Parse(packetValues.Groups[1].Value),
                    Time = Int32.Parse(packetValues.Groups[2].Value),
                    Ttl = Int32.Parse(packetValues.Groups[3].Value)
                };
            }

            return packet;
        }

        /// <summary>
        /// Saves data from output to the RequestRun instance.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="requestRun"></param>
        private void SaveDataFromPingOutput(string text, RequestRun requestRun)
        {
            /*
            Ping command raw output:
            
            Reply from 46.8.8.200: bytes=32 time=32ms TTL=49
            Ping statistics for 46.8.8.200:
                Packets: Sent = 1, Received = 1, Lost = 0 (0% loss),
            Approximate round trip times in milli-seconds:
                Minimum = 32ms, Maximum = 32ms, Average = 32ms
            */

            // read and capture output
            var packet = ReadPacketFromOutput(text, requestRun);
            var statistics = Regex.Match(text, @"Sent = (\d+), Received = (\d+), Lost = (\d+)");
            var times = Regex.Match(text, @"Minimum = (\d+)ms, Maximum = (\d+)");


            requestRun.Packets.Enqueue(packet);

            // increase counters
            if (statistics.Groups[1].Value == "1")
                requestRun.PacketsSent++;
            if (statistics.Groups[2].Value == "1")
                requestRun.PacketsRecieved++;
            if (statistics.Groups[3].Value == "1")
                requestRun.PacketsLost++;
            // set max or min
            int min = Int32.Parse(times.Groups[1].Value);
            int max = Int32.Parse(times.Groups[2].Value);
            if (min < requestRun.MinTime)
                requestRun.MinTime = min;
            if (max > requestRun.MaxTime)
                requestRun.MaxTime = max;

            // calculate the average
            requestRun.TimeSum += packet.Time;
            requestRun.AverageTime = (float)requestRun.TimeSum / requestRun.Packets.Count;
        }

        /// <summary>
        /// Converts hostname to IPv4.
        /// </summary>
        /// <param name="requestedAddress"></param>
        /// <returns>IPv4 as string or null</returns>
        public string? Hostname2Ipv4(string requestedAddress)
        {
            IPAddress? address = null;

            try
            {
                address = Dns.GetHostAddresses(requestedAddress).FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            }
            catch (Exception e)
            {
                console.LogError($"Something went wrong while converting address to ipv4.\nError message: {e}");
                console.LogWarning("Host does not exists or no internet connection.");
                return null;
            }

            if (address != null)
                return address.ToString();

            console.LogWarning($"DNS server did not return any IPv4 address for the requested hostname {requestedAddress}");
            console.LogInfo("Using orignial address instead.");
            return null;
        } 
    }
}

using PingRequester.Data.DataObjects;
using System.Diagnostics;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using PingRequester.Data;
using System.Text.RegularExpressions;

namespace PingRequester.BusinessLayer
{
    /// <summary>
    /// Request service logic instance.
    /// </summary>
    public class RequestService
    {
        private string stdout;
        private int remainingRequests;
        private int remainingAttempts;
        private IConsoleService console;
        private Requester requester;
        private ProcessStartInfo psi;

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        /// <param name="requester"></param>
        public RequestService(Requester requester, IConsoleService console)
        {
            this.console = console;
            this.requester = requester;
            this.remainingRequests = requester.NumberOfPR;
            this.remainingAttempts = requester.Attempts;
            
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
                    console.LogInfo("Stop signal was detected.");
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
            if (requestRun.IPv4 == null)
                this.psi.Arguments = $"-n 1 -l {requestRun.PacketSize} {requestRun.Hostname}";
            else
                this.psi.Arguments = $"-n 1 -l {requestRun.PacketSize} {requestRun.IPv4}";

            using (Process? process = await Task.Run(() => Process.Start(this.psi)))
            {
                stdout = await process.StandardOutput.ReadToEndAsync();
                await process.WaitForExitAsync();

                if (stdout.StartsWith("Ping request could not find host"))
                {
                    string warning = "Ping request could not find host.";
                    if (!requester.InfiniteLoop)
                        warning += $" Remaining attempts: {this.remainingAttempts}";
                    console.LogWarning(warning);
                    LowerStatusCount();
                }
                else if (stdout.Contains("Request timed out"))
                {
                    console.LogWarning("Request timed out.", true);
                    LowerStatusCount();
                }
                else
                {
                    SaveDataFromPingOutput(stdout, requester.RequestRun);
                    requester.mainform.OverwriteRequestRunUI(requestRun);

                    console.LogInfo($"Ping sent to {requestRun.Hostname} at {DateTime.Now}");
                    this.remainingRequests--;
                }
            }
        }

        private void LowerStatusCount()
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

        private Packet ReadPacketFromOutput(string text, RequestRun rr)
        {
            Match packetValues;
            Packet packet;

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
            else
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

        private void SaveDataFromPingOutput(string text, RequestRun requestRun)
        {
            /*
            Ring command raw output:
            
            Reply from 46.8.8.200: bytes=32 time=32ms TTL=49
            Ping statistics for 46.8.8.200:
                Packets: Sent = 1, Received = 1, Lost = 0 (0% loss),
            Approximate round trip times in milli-seconds:
                Minimum = 32ms, Maximum = 32ms, Average = 32ms
            */

            var packet = ReadPacketFromOutput(text, requestRun);
            var statistics = Regex.Match(text, @"Sent = (\d+), Received = (\d+), Lost = (\d+)");
            var times = Regex.Match(text, @"Minimum = (\d+)ms, Maximum = (\d+)");


            requestRun.Packets.Enqueue(packet);

            if (statistics.Groups[1].Value == "1")
                requestRun.PacketsSent++;
            if (statistics.Groups[2].Value == "1")
                requestRun.PacketsRecieved++;
            if (statistics.Groups[3].Value == "1")
                requestRun.PacketsLost++;
            int min = Int32.Parse(times.Groups[1].Value);
            int max = Int32.Parse(times.Groups[2].Value);
            if (min < requestRun.MinTime)
                requestRun.MinTime = min;
            if (max > requestRun.MaxTime)
                requestRun.MaxTime = max;

            requestRun.TimeSum += packet.Time;
            requestRun.AverageTime = (float)requestRun.TimeSum / requestRun.Packets.Count;
        }

        public string? Hostname2Ipv4(string requestedAddress)
        {
            IPAddress? address = null;

            try
            {
                address = Dns.GetHostAddresses(requestedAddress).FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
            }
            catch (Exception e)
            {
                console.LogError($"Something went wrong while converting address to ipv4. Error message: {e}");
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

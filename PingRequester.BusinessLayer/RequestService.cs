using PingRequester.Data.DataObjects;
using System.Diagnostics;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using PingRequester.Data;

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
                    console.LogWarning($"Ping request could not find host. Remaining attempts: {this.remainingAttempts}");
                    if (!requester.InfiniteLoop)
                    {
                        this.remainingAttempts--;

                        if (requester.Mode == "Precise")
                        {
                            console.LogInfo("Remaining requests reset, precise mode active.");
                            this.remainingRequests = requester.NumberOfPR;
                        }
                    }

                    requester.PingSent = false;
                }
                else
                {
                    console.LogInfo($"Ping sent to {requestRun.Hostname} at {DateTime.Now}");
                    this.remainingRequests--;
                    requester.PingSent = true;
                }
            }
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

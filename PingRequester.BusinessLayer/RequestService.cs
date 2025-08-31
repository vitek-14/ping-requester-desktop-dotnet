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
                Arguments = $"-n 1 {requester.RequestedAddress}",
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
                Console.WriteLine($"PR sent; {this.remainingRequests} remaining");
                // TODO: check if interruption request was created
                SendRequest();
                Console.WriteLine($"Ping Sent: {requester.PingSent}");
                await Task.Delay(requester.RefreshRate * 1000);
            }
        }

        /// <summary>
        /// Sends single ping request.
        /// </summary>
        private void SendRequest()
        {
            using (var process = Process.Start(this.psi))
            {
                stdout = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                if (stdout.StartsWith("Ping request could not find host"))
                {
                    if (!requester.InfiniteLoop)
                    {
                        this.remainingAttempts--;

                        if (requester.Mode == "Precise")
                            this.remainingRequests = requester.NumberOfPR;
                    }

                    requester.PingSent = false;
                }
                else
                {
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
            }

            if (address != null)
                return address.ToString();

            console.LogError($"Requested address {requestedAddress} does not corresponds with any ipv4 address.");
            return null;
        }
    }
}

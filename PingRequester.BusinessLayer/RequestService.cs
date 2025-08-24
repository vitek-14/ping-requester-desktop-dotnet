using PingRequester.Data.DataObjects;
using System.Diagnostics;

namespace PingRequester.BusinessLayer
{
    public class RequestService
    {
        private string stdout;
        private int remainingRequests;
        private int remainingAttempts;
        private Requester requester;
        private ProcessStartInfo psi;

        public RequestService(Requester requester)
        {
            this.requester = requester;
            this.remainingRequests = requester.NumberOfPR;
            this.remainingAttempts = requester.Attempts;
            
            this.psi = new ProcessStartInfo
            {
                FileName = "ping",
                Arguments = $"-n 1 {requester.RequestedAdress}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
        }

        public string Stdout { get; set; }

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
    }
}

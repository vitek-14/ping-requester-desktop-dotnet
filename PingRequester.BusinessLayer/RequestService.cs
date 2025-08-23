using PingRequester.Data.DataObjects;
using System.Diagnostics;

namespace PingRequester.BusinessLayer
{
    public class RequestService
    {
        private string stdout;
        private int remainingRequests;
        private Requester requester;

        public RequestService(Requester requester)
        {
            this.requester = requester;
            this.remainingRequests = requester.NumberOfPR;
        }

        public string Stdout { get; set; }

        public async void BeginRequestingAsync()
        {
            while (this.remainingRequests > 0)
            {
                Console.WriteLine($"PR sent; {this.remainingRequests} remaining");
                SendRequest();
                await Task.Delay(requester.RefreshRate * 1000);
            }
        }

        private bool SendRequest()
        {

            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"ping -n 1 {requester.RequestedAdress}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(psi))
            {
                stdout = process.StandardOutput.ReadToEnd();

                if (stdout.StartsWith("Ping request could not find host"))
                {
                    requester.PingSent = false;
                }
                else
                {
                    this.remainingRequests--;
                    requester.PingSent = true;
                }
            }

            return requester.PingSent;
        }
    }
}

using PingRequester.Data;
using System.Diagnostics;

namespace PingRequester.BusinessLayer
{
    public class DataLayerService
    {
        private string stdout;
        private int remainingRequests;
        private Requester requester;

        public DataLayerService(Requester requester)
        {
            this.requester = requester;
            this.remainingRequests = requester.NumberOfPR;
        }

        public string Stdout { get; set; }

        public void BeginRequesting()
        {
            while (this.remainingRequests > 0)
            {
                SendRequest();
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

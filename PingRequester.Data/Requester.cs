using PingRequester.BusinessLayer;


namespace PingRequester.Data
{
    public class Requester
    {
        private string requestedAdress;
        private bool connected;
        private int pauseTime;
        private int numberOfPR;
        private int numberOfTries;
        private bool infiniteLoop;
        private bool showNotification;
        private bool makeSound;

        public Requester()
        {
        }

        public string RequestedAdress { get; set; }
        public bool Connected { get; set; }
        public int PauseTime { get; set; }
        public int NumberOfPR { get; set; }
        public int NumberOfTries { get; set; }
        public bool InfiniteLoop { get; set; }
        public bool ShowNotification { get; set; }
        public bool MakeSound { get; set; }

    }
}

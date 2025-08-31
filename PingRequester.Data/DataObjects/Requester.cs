using PingRequester.Data.Base;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Requester class extending DataObject class.
    /// </summary>
    public class Requester : DataObject
    {
        private string requestedAddress;
        private string mode;
        private bool pingSent;
        private int refreshRate;
        private int numberOfPR;
        private int attempts;
        private bool infiniteLoop;
        private bool showNotification;
        private bool makeSound;
        private int packetSize;
        private bool stopSignal;
        private RequestRun requestRun;

        /// <summary>
        /// Default constructor of Requester class.
        /// </summary>
        public Requester()
        {
        }

        public string RequestedAddress
        {
            get => requestedAddress;
            set => SetProperty(ref requestedAddress, value);
        }

        public string Mode
        {
            get => mode;
            set => SetProperty(ref mode, value);
        }

        public bool PingSent
        {
            get => pingSent;
            set => SetProperty(ref pingSent, value);
        }

        public int RefreshRate
        {
            get => refreshRate;
            set => SetProperty(ref refreshRate, value);
        }

        public int NumberOfPR
        {
            get => numberOfPR;
            set => SetProperty(ref numberOfPR, value);
        }

        public int Attempts
        {
            get => attempts;
            set => SetProperty(ref attempts, value);
        }

        public bool InfiniteLoop
        {
            get => infiniteLoop;
            set => SetProperty(ref infiniteLoop, value);
        }

        public bool ShowNotification
        {
            get => showNotification;
            set => SetProperty(ref showNotification, value);
        }

        public bool MakeSound
        {
            get => makeSound;
            set => SetProperty(ref makeSound, value);
        }

        public int PacketSize
        {
            get => packetSize;
            set => SetProperty(ref packetSize, value);
        }

        public bool StopSignal
        {
            get => stopSignal;
            set => SetProperty(ref stopSignal, value);
        }

        public RequestRun RequestRun
        {
            get => requestRun;
            set => SetProperty(ref requestRun, value);
        }
    }
}

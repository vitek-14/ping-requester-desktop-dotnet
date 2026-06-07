using PingRequester.Data.Base;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Requester class extending DataObject class.
    /// </summary>
    public class Requester : DataObject
    {
        public event Action<RequestRun>? RequestRunUpdated;

        private string requestedAddress;
        private string mode;
        private int refreshRate;
        private int numberOfPR;
        private int attempts;
        private bool infiniteLoop;
        private bool stopWhenSuccess;
        private Settings settings;
        private int packetSize;
        private bool stopSignal;
        private RequestRun requestRun;

        /// <summary>
        /// Default constructor of Requester class.
        /// </summary>
        public Requester()
        {
        }

        public void OnRequestRunUpdated(RequestRun requestRun)
        {
            RequestRunUpdated?.Invoke(requestRun);
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

        public bool StopWhenSuccess
        {
            get => stopWhenSuccess;
            set => SetProperty(ref stopWhenSuccess, value);
        }

        public Settings Settings
        {
            get => settings;
            set => SetProperty(ref settings, value);
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

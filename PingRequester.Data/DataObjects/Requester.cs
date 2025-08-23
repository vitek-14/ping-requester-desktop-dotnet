using PingRequester.Data.Base;
using PingRequester.Data.Containers;

namespace PingRequester.Data.DataObjects
{
    public class Requester : DataObject
    {
        private string requestedAdress;
        private bool pingSent;
        private int pauseTime;
        private int numberOfPR;
        private int numberOfTries;
        private bool infiniteLoop;
        private bool showNotification;
        private bool makeSound;
        private PackageCollection pingPackages;

        public Requester()
        {
        }

        public string RequestedAdress
        {
            get => requestedAdress;
            set => SetProperty(ref requestedAdress, value);
        }

        public bool PingSent
        {
            get => pingSent;
            set => SetProperty(ref pingSent, value);
        }

        public int PauseTime
        {
            get => pauseTime;
            set => SetProperty(ref pauseTime, value);
        }

        public int NumberOfPR
        {
            get => numberOfPR;
            set => SetProperty(ref numberOfPR, value);
        }

        public int NumberOfTries
        {
            get => numberOfTries;
            set => SetProperty(ref numberOfTries, value);
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

        public PackageCollection PingPackages
        {
            get => pingPackages ?? new PackageCollection();
            set => SetProperty(ref pingPackages, value);
        }
    }
}

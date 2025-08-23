namespace PingRequester.Data
{
    public class Requester
    {
        private string requestedAdress;
        private bool connected;
        private decimal pauseTime;
        private decimal numberOfPR;
        private decimal numberOfTries;
        private bool infiniteLoop;
        private bool showNotification;
        private bool makeSound;

        public Requester()
        {
        }

        public string RequestedAdress
        {
            get => requestedAdress;
            set => SetProperty(ref requestedAdress, value);
        }

        public bool Connected
        {
            get => connected;
            set => SetProperty(ref connected, value);
        }

        public decimal PauseTime
        {
            get => pauseTime;
            set => SetProperty(ref pauseTime, value);
        }

        public decimal NumberOfPR
        {
            get => numberOfPR;
            set => SetProperty(ref numberOfPR, value);
        }

        public decimal NumberOfTries
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

        private static bool SetProperty<T>(ref T property, T value)
        {
            if (property == null)
                throw new ArgumentNullException($"Error: {nameof(property)} cannot be null.");
            if (property.Equals(value))
                return false;

            property = value;
            return true;
        }

    }
}

using PingRequester.Data.Base;
using System.Text.Json.Serialization;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Preferences class extending DataObject class.
    /// </summary>
    public class Preferences : DataObject
    {
        private string pingTarget;
        private string mode;
        private int refreshRate;
        private int numberOfPingRequests;
        private int attempts;
        private int packetSize;
        private bool infiniteLoop;
        private bool makeSound;
        private bool showNotification;

        /// <summary>
        /// Default contructor of Preferences class.
        /// </summary>
        public Preferences()
        {
        }

        [JsonPropertyName("ping target")]
        public string PingTarget 
        { 
            get => pingTarget;
            set => SetProperty(ref pingTarget, value);
        }

        [JsonPropertyName("mode")]
        public string Mode
        {
            get => mode;
            set => SetProperty(ref mode, value);
        }

        [JsonPropertyName("refresh rate")]
        public int RefreshRate
        {
            get => refreshRate;
            set => SetProperty(ref refreshRate, value);
        }

        [JsonPropertyName("number of ping requests")]
        public int NumberOfPR
        {
            get => numberOfPingRequests;
            set => SetProperty(ref numberOfPingRequests, value);
        }

        [JsonPropertyName("attempts")]
        public int Attempts
        {
            get => attempts;
            set => SetProperty(ref attempts, value);
        }

        [JsonPropertyName("packet size")]
        public int PacketSize
        {
            get => packetSize;
            set => SetProperty(ref packetSize, value);
        }

        [JsonPropertyName("infinite loop")]
        public bool InfiniteLoop
        {
            get => infiniteLoop;
            set => SetProperty(ref infiniteLoop, value);
        }

        [JsonPropertyName("make sound")]
        public bool MakeSound
        {
            get => makeSound;
            set => SetProperty(ref makeSound, value);
        }

        [JsonPropertyName("show notification")]
        public bool ShowNotification
        {
            get => showNotification;
            set => SetProperty(ref showNotification, value);
        }
    }
}

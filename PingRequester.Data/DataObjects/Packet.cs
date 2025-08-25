using PingRequester.Data.Base;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Packet class extending DataObject class.
    /// </summary>
    public class Packet : DataObject
    {
        private int bytes;
        private int time;
        private int ttl;

        /// <summary>
        /// Default constructor of Packet class.
        /// </summary>
        public Packet()
        {
        }

        public int Bytes
        {
            get => bytes;
            set => SetProperty(ref bytes, value);
        }

        public int Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }

        public int Ttl
        {
            get => ttl;
            set => SetProperty(ref ttl, value);
        }
    }
}

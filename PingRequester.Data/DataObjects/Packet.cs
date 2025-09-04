using PingRequester.Data.Base;

namespace PingRequester.Data.DataObjects
{
    /// <summary>
    /// Packet class extending DataObject class.
    /// </summary>
    public class Packet
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

        public int Bytes { get; set; }

        public int Time { get; set; }

        public int Ttl { get; set; }
    }
}

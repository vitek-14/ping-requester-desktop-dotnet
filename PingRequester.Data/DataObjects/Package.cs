using PingRequester.Data.Base;

namespace PingRequester.Data.DataObjects
{
    public class Package : DataObject
    {
        private int bytes;
        private int time;
        private int ttl;

        public Package()
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

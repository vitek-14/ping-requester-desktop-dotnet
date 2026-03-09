using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.Entities
{
    public class UserPreferences : Entity
    {
        public string PingTarget { get; set; }
        public string Mode { get; set; }
        public int RefreshRate { get; set; }
        public bool InfiniteLoop { get; set; }
        public bool StopWhenSuccess { get; set; }
        public int PingRequestCount { get; set; }
        public int Attempts { get; set; }
        public int PacketSize { get; set; }

        public List<RequestRunSession> Sessions { get; set; } = new();
    }
}

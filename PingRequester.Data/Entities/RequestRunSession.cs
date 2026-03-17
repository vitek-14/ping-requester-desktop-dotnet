using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data.Entities
{
    /// <summary>
    /// Request run session entity used in the EF's logic.
    /// </summary>
    public class RequestRunSession : Entity
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string PingTarget { get; set; }
        public string Ipv4 { get; set; }
        public int PacketSize { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }
        public int Lost { get; set; }
        public int MaxResponseTimeMs { get; set; }
        public int MinResponseTimeMs { get; set; }
        public float AverageResponseTimeMs { get; set; }

        public int UserPreferencesId { get; set; }
        public UserPreferences UserPreferences { get; set; }
    }
}

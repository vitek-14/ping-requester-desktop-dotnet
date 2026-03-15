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

        public override bool Equals(object? obj)
        {
            if (obj is not UserPreferences other)
            {
                return false;
            }

            return this.StopWhenSuccess == other.StopWhenSuccess
                && this.InfiniteLoop == other.InfiniteLoop
                && this.PacketSize == other.PacketSize
                && this.Attempts == other.Attempts
                && this.Mode == other.Mode
                && this.PingRequestCount == other.PingRequestCount
                && this.PingTarget == other.PingTarget
                && this.RefreshRate == other.RefreshRate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                StopWhenSuccess,
                InfiniteLoop,
                PacketSize,
                Attempts,
                Mode,
                PingRequestCount,
                PingTarget,
                RefreshRate
            );
        }
    }
}

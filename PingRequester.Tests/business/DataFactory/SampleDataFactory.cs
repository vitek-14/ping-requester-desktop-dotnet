using PingRequester.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Tests.business.DataFactory
{
    internal static class SampleDataFactory
    {
        internal static Preferences GetPreferencesSampleData()
        {
            return new Preferences
            {
                PingTarget = "www.seznam.cz",
                Mode = "Precise",
                RefreshRate = 5,
                NumberOfPR = 20,
                Attempts = 3,
                PacketSize = 32,
                InfiniteLoop = false,
                StopWhenSuccess = false,
                AutoSave = true
            };
        }
    }
}

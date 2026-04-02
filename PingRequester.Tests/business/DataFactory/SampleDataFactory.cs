using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;
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

        internal static UserPreferences GetUserPreferencesSampleData()
        {
            return new UserPreferences
            {
                PingTarget = "8.8.8.8",
                Mode = "Precise",
                RefreshRate = 500,
                InfiniteLoop = true,
                StopWhenSuccess = false,
                PingRequestCount = 10,
                Attempts = 2,
                PacketSize = 64
            };
        }
    }
}

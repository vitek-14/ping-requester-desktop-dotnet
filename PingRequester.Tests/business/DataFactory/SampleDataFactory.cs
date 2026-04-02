using PingRequester.Data;
using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;

namespace PingRequester.Tests.business.DataFactory
{
    internal class SampleDataFactory
    {
        private readonly MyDbContext _context;

        internal SampleDataFactory(MyDbContext context)
        {
            _context = context;
        }

        internal void TestDatabaseInit()
        {
            var userPreferences = GetUserPreferences();
            var requestRunSessions = GetRequestRunSessions();

            _context.AddRange(userPreferences);
            _context.AddRange(requestRunSessions);

            _context.SaveChanges();
        }

        private List<UserPreferences> GetUserPreferences()
        {
            return new List<UserPreferences>()
            {
                new UserPreferences
                {
                    PingTarget = "localhost",
                    Mode = "Precise",
                    RefreshRate = 1000,
                    InfiniteLoop = false,
                    StopWhenSuccess = true,
                    PingRequestCount = 4,
                    Attempts = 1,
                    PacketSize = 32
                },
                new UserPreferences
                {
                    PingTarget = "www.google.com",
                    Mode = "Aggressive",
                    RefreshRate = 500,
                    InfiniteLoop = true,
                    StopWhenSuccess = false,
                    PingRequestCount = 10,
                    Attempts = 3,
                    PacketSize = 64
                }
            };
        }

        private List<RequestRunSession> GetRequestRunSessions()
        {
            var prefs = GetUserPreferences();
            var pref1 = prefs[0];
            var pref2 = prefs[1];

            return new List<RequestRunSession>
            {
                new RequestRunSession
                {
                    Start = DateTime.Now.AddMinutes(-60),
                    End = DateTime.Now.AddMinutes(-55),
                    PingTarget = "localhost",
                    Ipv4 = "127.0.0.1",
                    PacketSize = 32,
                    Sent = 4, Received = 4, Lost = 0,
                    MinResponseTimeMs = 15, MaxResponseTimeMs = 25, AverageResponseTimeMs = 20.5f,
                    UserPreferences = pref1
                },
                new RequestRunSession
                {
                    Start = DateTime.Now.AddMinutes(-30),
                    End = DateTime.Now.AddMinutes(-25),
                    PingTarget = "localhost",
                    Ipv4 = "127.0.0.1",
                    PacketSize = 32,
                    Sent = 4, Received = 3, Lost = 1,
                    MinResponseTimeMs = 18, MaxResponseTimeMs = 120, AverageResponseTimeMs = 45.0f,
                    UserPreferences = pref1
                },
                new RequestRunSession
                {
                    Start = DateTime.Now.AddHours(-2),
                    End = DateTime.Now.AddHours(-1),
                    PingTarget = "www.google.com",
                    Ipv4 = "142.251.36.68",
                    PacketSize = 64,
                    Sent = 10, Received = 10, Lost = 0,
                    MinResponseTimeMs = 10, MaxResponseTimeMs = 15, AverageResponseTimeMs = 12.2f,
                    UserPreferences = pref2
                },
                new RequestRunSession
                {
                    Start = DateTime.Now.AddDays(-1),
                    End = DateTime.Now.AddDays(-1).AddMinutes(10),
                    PingTarget = "www.google.com",
                    Ipv4 = "142.251.36.68",
                    PacketSize = 64,
                    Sent = 10, Received = 5, Lost = 5,
                    MinResponseTimeMs = 12, MaxResponseTimeMs = 500, AverageResponseTimeMs = 150.8f,
                    UserPreferences = pref2
                }
            };
        }

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

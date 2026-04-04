using PingRequester.Data.Entities;
using PingRequester.Tests.business.DataFactory;
using Xunit;

namespace PingRequester.Tests.business
{
    public class PingRequestDataTests : DatabaseTestBase, IClassFixture<DatabaseTestBase>
    {
        public PingRequestDataTests() : base()
        {
        }

        [Fact]
        public void AddPingRequestRun_NewPreference_AddsBothToDatabase()
        {
            // Arrange
            int prefCountBefore = context.Preferences.Count();
            int sessionCountBefore = context.Sessions.Count();

            var newPref = new UserPreferences
            {
                PingTarget = "unique.target.com",
                Mode = "Precise",
                PacketSize = 32
            };
            var newSession = new RequestRunSession
            {
                PingTarget = "unique.target.com",
                Start = DateTime.Now,
                Ipv4 = "123.123.123.1"
            };

            // Act
            PingRequestFacade.AddPingRequestRun(newPref, newSession);

            // Assert
            Assert.Equal(prefCountBefore + 1, context.Preferences.Count());
            Assert.Equal(sessionCountBefore + 1, context.Sessions.Count());
            Assert.True(newSession.UserPreferencesId > 0);
            Assert.Equal(newPref.Id, newSession.UserPreferencesId);
        }

        [Fact]
        public void AddPingRequestRun_ExistingPreference_AddsOnlySessionAndLinksIt()
        {
            // Arrange
            var existingPref = context.Preferences.First();
            int prefCountBefore = context.Preferences.Count();
            int sessionCountBefore = context.Sessions.Count();

            var duplicatePref = new UserPreferences
            {
                PingTarget = existingPref.PingTarget,
                Mode = existingPref.Mode,
                RefreshRate = existingPref.RefreshRate,
                InfiniteLoop = existingPref.InfiniteLoop,
                StopWhenSuccess = existingPref.StopWhenSuccess,
                PingRequestCount = existingPref.PingRequestCount,
                Attempts = existingPref.Attempts,
                PacketSize = existingPref.PacketSize
            };

            var newSession = new RequestRunSession
            {
                PingTarget = existingPref.PingTarget,
                Start = DateTime.Now,
                Ipv4 = "123.123.123.1"
            };

            // Act
            PingRequestFacade.AddPingRequestRun(duplicatePref, newSession);

            // Assert
            Assert.Equal(prefCountBefore, context.Preferences.Count());
            Assert.Equal(sessionCountBefore + 1, context.Sessions.Count());
            Assert.Equal(existingPref.Id, newSession.UserPreferencesId);
        }

        [Fact]
        public void PurgeDatabase_WhenCalled_RemovesAllRecords()
        {
            // Act
            PingRequestFacade.PurgeDatabase();

            // Assert
            Assert.Empty(context.Preferences);
            Assert.Empty(context.Sessions);
        }

        [Fact]
        public void SessionsAndPreferences_Properties_ReturnInitializedServices()
        {
            // Act & Assert
            Assert.NotNull(PingRequestFacade.Sessions);
            Assert.NotNull(PingRequestFacade.Preferences);
        }
    }
}
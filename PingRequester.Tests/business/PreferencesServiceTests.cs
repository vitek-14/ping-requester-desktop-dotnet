using PingRequester.Data.Entities;
using PingRequester.Tests.business.DataFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PingRequester.Tests.business
{
    public class PreferencesServiceTests : DatabaseTestBase, IClassFixture<DatabaseTestBase>
    {
        public PreferencesServiceTests() : base()
        {
        }

        [Fact]
        public void GetById_ExistingId_ReturnsCorrectPreference()
        {
            // Arrange
            int id = 1;
            string target = context.Preferences.FirstOrDefault(p => p.Id == id).PingTarget;

            // Act
            var result = PreferencesService.GetById(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(target, result.PingTarget);
        }

        [Fact]
        public void GetById_NonExistingId_ReturnsNull()
        {
            // Arrange & Act
            var result = PreferencesService.GetById(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllSampleRecords()
        {
            // Arrange
            int expectedCount = context.Preferences.Count();

            // Act
            var result = PreferencesService.GetAll();

            // Assert
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetAllSessions_ValidPreference_ReturnsLinkedSessions()
        {
            // Arrange
            var pref = context.Preferences.FirstOrDefault();
            int expectedSessionsCount = context.Sessions.Count(s => s.UserPreferencesId == pref.Id);

            // Act
            var sessions = PreferencesService.GetAllSessions(pref);

            // Assert
            Assert.Equal(expectedSessionsCount, sessions.Count());
            Assert.All(sessions, s => Assert.Equal(pref.Id, s.UserPreferencesId));
        }

        [Fact]
        public void Add_ValidEntity_ShouldSaveToDatabase()
        {
            // Arrange
            int countBefore = context.Preferences.Count();
            var newPref = new UserPreferences
            {
                PingTarget = "1.1.1.1",
                Mode = "Precise",
                RefreshRate = 100,
                PingRequestCount = 5
            };

            // Act
            var result = PreferencesService.Add(newPref);

            // Assert
            Assert.True(result);
            Assert.Equal(countBefore + 1, context.Preferences.Count());
            Assert.Contains(context.Preferences, p => p.PingTarget == "1.1.1.1");
        }

        [Fact]
        public void Add_NullEntity_ReturnsFalse()
        {
            // Act
            var result = PreferencesService.Add(null!);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Update_ExistingEntity_ShouldModifyDataInDatabase()
        {
            // Arrange
            var pref = context.Preferences.First();
            string newTarget = "dynamic.update.test";
            pref.PingTarget = newTarget;

            // Act
            var result = PreferencesService.Update(pref);

            var updatedInDb = context.Preferences.Find(pref.Id);

            // Assert
            Assert.True(result);
            Assert.Equal(newTarget, updatedInDb?.PingTarget);
        }

        [Fact]
        public void Delete_ExistingEntity_ShouldRemoveFromDatabase()
        {
            // Arrange
            var pref = context.Preferences.First();
            int idToDelete = pref.Id;

            // Act
            var result = PreferencesService.Delete(pref);

            // Assert
            Assert.True(result);
            Assert.False(context.Preferences.Any(p => p.Id == idToDelete));
        }

        [Fact]
        public void FindMatching_SameProperties_ReturnsMatchingPreference()
        {
            // Arrange
            var existing = context.Preferences.First();
            var criteria = new UserPreferences
            {
                PingTarget = existing.PingTarget,
                Mode = existing.Mode,
                RefreshRate = existing.RefreshRate,
                InfiniteLoop = existing.InfiniteLoop,
                StopWhenSuccess = existing.StopWhenSuccess,
                PingRequestCount = existing.PingRequestCount,
                Attempts = existing.Attempts,
                PacketSize = existing.PacketSize
            };

            // Act
            var result = PreferencesService.FindMatching(criteria);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(existing.Id, result?.Id);
        }
    }
}

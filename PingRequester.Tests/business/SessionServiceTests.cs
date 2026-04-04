using PingRequester.Data.Entities;
using PingRequester.Tests.business.DataFactory;
using Xunit;

namespace PingRequester.Tests.business
{
    public class SessionServiceTests : DatabaseTestBase
    {
        public SessionServiceTests() : base()
        {
        }

        [Fact]
        public void GetById_ExistingId_ReturnsCorrectSession()
        {
            // Arrange
            var expected = context.Sessions.First();
            int id = expected.Id;

            // Act
            var result = SessionService.GetById(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expected.PingTarget, result.PingTarget);
        }

        [Fact]
        public void GetById_NonExistingId_ReturnsNull()
        {
            // Act
            var result = SessionService.GetById(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetAll_WhenCalled_ReturnsAllSampleRecords()
        {
            // Arrange
            int expectedCount = context.Sessions.Count();

            // Act
            var result = SessionService.GetAll();

            // Assert
            Assert.Equal(expectedCount, result.Count());
        }

        [Fact]
        public void GetPreferences_ValidSession_ReturnsLinkedPreference()
        {
            // Arrange
            var session = context.Sessions.First();
            int expectedPrefId = session.UserPreferencesId;

            // Act
            var result = SessionService.GetPreferences(session);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedPrefId, result.Id);
        }

        [Fact]
        public void Add_ValidEntity_ShouldSaveToDatabase()
        {
            // Arrange
            int countBefore = context.Sessions.Count();
            var pref = context.Preferences.First();

            var newSession = new RequestRunSession
            {
                PingTarget = "test.target.cz",
                Ipv4 = "123.123.123.1",
                Start = DateTime.Now,
                End = DateTime.Now.AddMinutes(5),
                UserPreferencesId = pref.Id,
                Sent = 10,
                Received = 10
            };

            // Act
            var result = SessionService.Add(newSession);

            // Assert
            Assert.True(result);
            Assert.Equal(countBefore + 1, context.Sessions.Count());
            Assert.Contains(context.Sessions, s => s.PingTarget == "test.target.cz");
        }

        [Fact]
        public void Add_NullEntity_ReturnsFalse()
        {
            // Act
            var result = SessionService.Add(null!);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Update_ExistingEntity_ShouldModifyDataInDatabase()
        {
            // Arrange
            var session = context.Sessions.First();
            int newSentCount = 999;
            session.Sent = newSentCount;

            // Act
            var result = SessionService.Update(session);

            // Assert
            Assert.True(result);

            // Kontrola přímo v DB
            var updatedInDb = context.Sessions.Find(session.Id);
            Assert.Equal(newSentCount, updatedInDb?.Sent);
        }

        [Fact]
        public void Delete_ExistingEntity_ShouldRemoveFromDatabase()
        {
            // Arrange
            var session = context.Sessions.First();
            int idToDelete = session.Id;

            // Act
            var result = SessionService.Delete(session);

            // Assert
            Assert.True(result);
            Assert.False(context.Sessions.Any(s => s.Id == idToDelete));
        }
    }
}
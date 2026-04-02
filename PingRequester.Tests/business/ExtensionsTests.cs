using PingRequester.BusinessLayer;
using PingRequester.Tests.business.DataFactory;
using Xunit;

namespace PingRequester.Tests.business
{
    public class ExtensionsTests : BusinessLayerTestBase, IClassFixture<BusinessLayerTestBase>
    {
        public ExtensionsTests() : base()
        {
        }

        [Fact]
        public void ToTimeStampFormat_ValidDate_ReturnsFormattedString()
        {
            // Arrange
            var date = new DateTime(2026, 4, 2, 13, 30, 0);
            string template = "yyyy-MM-dd_HH-mm";

            // Act
            var result = date.ToTimeStampFormat(template);

            // Criterion
            Assert.Equal("2026-04-02_13-30", result);
        }

        [Theory]
        [InlineData("Log_2026-04-02.txt", "yyyy-MM-dd", 2026, 4, 2)]
        [InlineData("Backup_02042026.bak", "ddMMyyyy", 2026, 4, 2)]
        [InlineData("C:\\Logs\\Session_202604021330.json", "yyyyMMddHHmm", 2026, 4, 2)]
        public void ToDateTime_ValidFileName_ReturnsCorrectDateTime(string fileName, string template, int year, int month, int day)
        {
            // Arrange & Act
            var result = fileName.ToDateTime(template);

            // Assert
            Assert.Equal(year, result.Year);
            Assert.Equal(month, result.Month);
            Assert.Equal(day, result.Day);
        }

        [Fact]
        public void ToDateTime_InvalidFormat_ThrowsException()
        {
            // Arrange
            string fileName = "Log_InvalidDate.txt";
            string template = "yyyy-MM-dd";

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => fileName.ToDateTime(template));
            Assert.Contains("Could not parse", ex.Message);
        }

        [Theory]
        [InlineData("yyyy-MM-dd", true)]
        [InlineData("dd.MM.yyyy HH:mm:ss", true)]
        [InlineData("HH:mm", true)]
        [InlineData("abc-def", false)]
        [InlineData("yyyy-MM-dd <script>", false)]
        [InlineData("", false)]
        public void TryParseToDateTime_Validation_ReturnsExpectedResult(string template, bool expected)
        {
            // Arrange & Act
            bool result = template.TryParseToDateTime();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MapToPreferences_ValidEntity_MapsAllPropertiesCorrectly()
        {
            // Arrange
            var userPref = UserPreferenceSampleData;

            // Act
            var result = userPref.MapToPreferences();

            // Assert
            Assert.Equal(userPref.PingTarget, result.PingTarget);
            Assert.Equal(userPref.Mode, result.Mode);
            Assert.Equal(userPref.RefreshRate, result.RefreshRate);
            Assert.Equal(userPref.InfiniteLoop, result.InfiniteLoop);
            Assert.Equal(userPref.StopWhenSuccess, result.StopWhenSuccess);
            Assert.Equal(userPref.PingRequestCount, result.NumberOfPR);
            Assert.Equal(userPref.Attempts, result.Attempts);
            Assert.Equal(userPref.PacketSize, result.PacketSize);
        }
    }
}

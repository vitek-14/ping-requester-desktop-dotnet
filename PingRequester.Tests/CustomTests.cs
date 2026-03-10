using Xunit;
using PingRequester.BusinessLayer.Services;

using PingRequester.Data.DataObjects;

namespace PingRequester.Tests
{
    public class CustomTests
    {
        public CustomTests()
        {
        }

        [Fact]
        public void GetJsonSettingsContentTest()
        {
            // Arrange
            var jsonSettingsService = new JsonService<Settings>("config/SettingsConfig.json");
            var settings = jsonSettingsService.LoadFileContent();

            // Assert
            Assert.NotNull(settings);
        }
    }
}

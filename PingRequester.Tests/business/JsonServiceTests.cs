using PingRequester.BusinessLayer.Services;
using PingRequester.Data.DataObjects;
using PingRequester.Tests.business.DataFactory;
using Xunit;

namespace PingRequester.Tests.business
{
    public class JsonServiceTests : BusinessLayerTestBase, IClassFixture<BusinessLayerTestBase>
    {
        public JsonServiceTests() : base()
        {
        }

        [Fact]
        public void Constructor_PreferencesPath_ShouldInitializeSuccessfully()
        {
            // Act
            var jsonService = new JsonService<Preferences>(PathPreferences);

            // Criterion
            Assert.NotNull(jsonService);
        }

        [Fact]
        public void Constructor_SettingsPath_ShouldInitializeSuccessfully()
        {
            // Act
            var jsonService = new JsonService<Preferences>(PathSettings);

            // Criterion
            Assert.NotNull(jsonService);
        }

        [Fact]
        public void Constructor_InvalidPath_ShouldThrowFileNotFoundException()
        {
            // Arrange
            string wrongPath = "worng/path/to/file.json";

            // Act & Criterion
            Assert.Throws<FileNotFoundException>(() => new JsonService<Preferences>(wrongPath));
        }

        [Fact]
        public void LoadFileContent_ValidJsonFile_ReturnsCorrectMappedObject()
        {
            // Arrange
            string path = Path.Combine(PathSampleData, "SampleJsonData.json");

            var jsonService = new JsonService<Preferences>(path);

            // Act
            var content = jsonService.LoadFileContent();

            // Criterion
            Assert.NotNull(content);

            Assert.Equal("www.seznam.cz", content.PingTarget);
            Assert.Equal("Aggressive", content.Mode);
            Assert.Equal(1, content.RefreshRate);
            Assert.Equal(3, content.NumberOfPR);
            Assert.Equal(1, content.Attempts);
            Assert.Equal(32, content.PacketSize);
            Assert.False(content.InfiniteLoop);
            Assert.False(content.StopWhenSuccess);
            Assert.False(content.AutoSave);
        }

        [Fact]
        public void WriteFileContent_ValidObject_SavesCorrectJsonMarkupToFile()
        {
            // Arrange
            var preferences = PreferenceSampleData;
            var filePath = Path.Combine(PathSampleData, "WriteFileContentTest_Preferences.json");

            if (!Path.Exists(filePath))
            {
                using (var sw = new StreamWriter(filePath))
                {
                    sw.Write("");
                }
            }

            var jsonService = new JsonService<Preferences>(filePath);

            // Act
            jsonService.WriteFileContent(preferences);

            // Criterion
            Assert.True(Path.Exists(filePath));

            string content;
            using (var sr = new StreamReader(filePath))
            {
                content = sr.ReadToEnd();
            }

            Assert.Contains(preferences.PingTarget.ToString(), content);
            Assert.Contains(preferences.Mode.ToString(), content);
            Assert.Contains(preferences.RefreshRate.ToString(), content);
            Assert.Contains(preferences.NumberOfPR.ToString(), content);
            Assert.Contains(preferences.PacketSize.ToString(), content);
            Assert.Contains(preferences.InfiniteLoop.ToString().ToLower(), content);
            Assert.Contains(preferences.StopWhenSuccess.ToString().ToLower(), content);
            Assert.Contains(preferences.AutoSave.ToString().ToLower(), content);
            Assert.Contains(preferences.Attempts.ToString(), content);
        }
    }
}

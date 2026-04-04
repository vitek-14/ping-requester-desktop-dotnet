using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;

namespace PingRequester.Tests.business.DataFactory
{
    /// <summary>
    /// Provides a base class for business layer unit tests, handling test data setup and cleanup.
    /// </summary>
    public class BusinessLayerTestBase : IDisposable
    {
        private string pathUnitTests;

        protected string PathPreferences { get; private set; }
        protected string PathSettings { get; private set; }
        protected string PathSampleData { get; private set; }
        protected Preferences PreferenceSampleData { get; private set; }
        protected UserPreferences UserPreferenceSampleData { get; private set; }

        /// <summary>
        /// Default constructor of the class. Sets up path variables and generates sample data.
        /// </summary>
        public BusinessLayerTestBase()
        {
            SetPaths();
            GenerateSampleData();
        }

        private void SetPaths()
        {
            pathUnitTests = AppDomain.CurrentDomain.BaseDirectory;
            PathPreferences = "config/PreferencesConfig.json";
            PathSettings = "config/SettingsConfig.json";
            PathSampleData = Path.Combine(
                pathUnitTests,
                "business",
                "DataFactory");
        }

        private void GenerateSampleData()
        {
            PreferenceSampleData = SampleDataFactory.GetPreferencesSampleData();
            UserPreferenceSampleData = SampleDataFactory.GetUserPreferencesSampleData();
        }

        /// <summary>
        /// Deletes all sample json files.
        /// </summary>
        private void DeleteCreatedJsonFiles()
        {
            var files = Directory.GetFiles(PathSampleData);

            foreach (var fileName in files)
            {
                // the only exception
                if (Path.GetFileName(fileName) == "SampleJsonData.json")
                    continue;

                File.Delete(fileName);
            }
        }

        public void Dispose()
        {
            DeleteCreatedJsonFiles();
        }
    }
}

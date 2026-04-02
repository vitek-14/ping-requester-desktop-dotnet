using PingRequester.Data.DataObjects;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected string PathSampleJsonData { get; private set; }
        protected Preferences PreferenceSampleData { get; private set; }
        protected UserPreferences UserPreferenceSampleData { get; private set; }

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
            PathSampleJsonData = Path.Combine(
                pathUnitTests,
                "business",
                "DataFactory");
        }

        private void GenerateSampleData()
        {
            PreferenceSampleData = SampleDataFactory.GetPreferencesSampleData();
            UserPreferenceSampleData = SampleDataFactory.GetUserPreferencesSampleData();
        }

        private void DeleteCreatedJsonFiles()
        {
            var files = Directory.GetFiles(PathSampleJsonData);

            foreach (var fileName in files)
            {
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

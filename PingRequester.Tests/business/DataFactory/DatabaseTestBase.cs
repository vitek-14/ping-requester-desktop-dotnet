using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PingRequester.BusinessLayer;
using PingRequester.BusinessLayer.Services;
using PingRequester.Data;

namespace PingRequester.Tests.business.DataFactory
{
    /// <summary>
    /// Provides a base class for testing database, handling test data setup and cleanup.
    /// </summary>
    public class DatabaseTestBase : BusinessLayerTestBase, IDisposable
    {
        private readonly string databasePath;
        protected readonly MyDbContext context;

        protected PreferencesService PreferencesService { get; private set; }
        protected SessionService SessionService { get; private set; }
        protected PingRequestData PingRequestFacade { get; private set; }

        /// <summary>
        /// Default constructor of the class.
        /// </summary>
        public DatabaseTestBase() : base()
        {
            databasePath = Path.Combine(PathSampleData, $"TestDb_{Guid.NewGuid():N}.sqlite");

            this.context = GetContext();

            PreferencesService = new PreferencesService(GetContext);
            SessionService = new SessionService(GetContext);
            PingRequestFacade = new PingRequestData(GetContext);

            PopulateDatabase();
        }

        private MyDbContext GetContext()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                    .UseSqlite($"Data Source={databasePath}")
                    .Options;

            var context = new MyDbContext(options);
            context.Database.EnsureCreated();

            return context;
        }

        /// <summary>
        /// Populates testing database with testing data.
        /// </summary>
        private void PopulateDatabase()
        {
            var sampleFactory = new SampleDataFactory(this.context);
            sampleFactory.TestDatabaseInit();
        }

        public void Dispose()
        {
            this.context.Dispose();

            SqliteConnection.ClearAllPools();

            if (File.Exists(databasePath))
            {
                File.Delete(databasePath);
            }

            base.Dispose();
        }
    }
}

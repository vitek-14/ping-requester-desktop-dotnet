using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PingRequester.BusinessLayer;
using PingRequester.BusinessLayer.Services;
using PingRequester.Data;

namespace PingRequester.Tests.business.DataFactory
{
    public class DatabaseTestBase : BusinessLayerTestBase, IDisposable
    {
        protected readonly string databasePath;
        protected readonly Func<MyDbContext> ContextFactory;
        protected readonly MyDbContext context;

        protected PreferencesService PreferencesService { get; private set; }
        protected SessionService SessionService { get; private set; }
        protected PingRequestData PingRequestFacade { get; private set; }

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

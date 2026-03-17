using PingRequester.BusinessLayer.Services;
using PingRequester.Data;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer
{
    /// <summary>
    /// Entry point (facade) for database operations.
    /// </summary>
    public class PingRequestData
    {
        private SessionService session;
        private PreferencesService preferences;

        /// <summary>
        /// Default cosntructor of the class.
        /// </summary>
        public PingRequestData()
        {
            session = new SessionService(CreateContext);
            preferences = new PreferencesService(CreateContext);
        }

        public SessionService Sessions { get => session; }
        public PreferencesService Preferences { get => preferences; }

        private MyDbContext CreateContext() => new MyDbContext();

        /// <summary>
        /// Adds ping request run to the databse including user preference.
        /// </summary>
        /// <param name="preferences"></param>
        /// <param name="session"></param>
        public void AddPingRequestRun(UserPreferences preferences, RequestRunSession session)
        {
            var matchingPreference = this.Preferences.FindMatching(preferences);

            if (matchingPreference == null)
            {
                this.Preferences.Add(preferences);
            }
            else
            {
                preferences = matchingPreference;
            }

            session.UserPreferencesId = preferences.Id;

            this.Sessions.Add(session);
        }

        /// <summary>
        /// Deletes all records from the database.
        /// </summary>
        public void PurgeDatabase()
        {
            var sessions = Sessions.GetAll();

            foreach (var session in sessions)
            {
                Sessions.Delete(session);
            }

            var preferences = Preferences.GetAll();

            foreach (var preference in preferences)
            {
                Preferences.Delete(preference);
            }
        }
    }
}

using PingRequester.BusinessLayer.Services;
using PingRequester.Data;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer
{
    public class PingRequestData
    {
        private SessionService session;
        private PreferencesService preferences;

        public PingRequestData()
        {
            session = new SessionService(CreateContext);
            preferences = new PreferencesService(CreateContext);
        }

        public SessionService Sessions { get => session; }
        public PreferencesService Preferences { get => preferences; }

        private MyDbContext CreateContext() => new MyDbContext();

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

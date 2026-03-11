using PingRequester.BusinessLayer.Services;
using PingRequester.Data;

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
    }
}

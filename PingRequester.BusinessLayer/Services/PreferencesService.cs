using PingRequester.Data;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer.Services
{
    public class PreferencesService : IEntityService<UserPreferences>
    {
        private readonly Func<MyDbContext> _contextFactory;

        public PreferencesService(Func<MyDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public UserPreferences? GetById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Preferences.FirstOrDefault(p => p.Id == id);
            }
        }

        public IEnumerable<UserPreferences> GetAll()
        {
            using (var context = _contextFactory())
            {
                return context.Preferences.ToList();
            }
        }

        public bool Add(UserPreferences entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Preferences.Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while adding entity to the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public bool Update(UserPreferences entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Preferences.Update(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while saving entity to the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public bool Delete(UserPreferences entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Preferences.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while saving entity to the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public IEnumerable<RequestRunSession> GetAllSessions(UserPreferences userPreference)
        {
            using (var context = _contextFactory())
            {
                return context.Sessions.Where(s => s.UserPreferencesId == userPreference.Id).ToList();
            }
        }

        public UserPreferences? FindMatching(UserPreferences preferences)
        {
            using (var context = _contextFactory())
            {
                return context.Preferences.AsEnumerable().FirstOrDefault(p => p.Equals(preferences));
            }
        }
    }
}

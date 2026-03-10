using PingRequester.Data;
using PingRequester.Data.Base;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer.Services
{
    public class PreferencesService : IEntityService<UserPreferences>
    {
        private readonly MyDbContext _context;

        public PreferencesService(MyDbContext context)
        {
            _context = context;
        }

        public UserPreferences? GetById(int id)
        {
            return _context.Preferences.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<UserPreferences> GetAll()
        {
            return _context.Preferences.ToList();
        }

        public bool Add(UserPreferences entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Preferences.Add(entity);
                _context.SaveChanges();
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
                _context.Preferences.Update(entity);
                _context.SaveChanges();
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
                _context.Preferences.Update(entity);
                _context.SaveChanges();
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
            return _context.Sessions.Where(s => s.UserPreferencesId == userPreference.Id).ToList();
        }
    }
}

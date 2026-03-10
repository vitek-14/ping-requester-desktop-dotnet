using PingRequester.Data;
using PingRequester.Data.Base;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer
{
    public class PreferencesService : IEntityService
    {
        private readonly MyDbContext _context;

        public PreferencesService(MyDbContext context)
        {
            _context = context;
        }

        public Entity? GetById(int id)
        {
            return _context.Preferences.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Entity> GetAll()
        {
            return _context.Preferences.ToList();
        }

        public bool Add(Entity entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Preferences.Add((UserPreferences)entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while adding entity to the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public bool Update(Entity entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Preferences.Update((UserPreferences)entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while saving entity to the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public bool Delete(Entity entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Preferences.Update((UserPreferences)entity);
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

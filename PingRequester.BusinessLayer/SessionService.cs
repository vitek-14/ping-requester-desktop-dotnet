using PingRequester.Data;
using PingRequester.Data.Base;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer
{
    public class SessionService : IEntityService
    {
        private readonly MyDbContext _context;

        public SessionService(MyDbContext context)
        {
            _context = context;
        }

        public Entity? GetById(int id)
        {
            return _context.Sessions.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Entity> GetAll()
        {
            return _context.Sessions.ToList();
        }

        public bool Add(Entity entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                _context.Sessions.Add((RequestRunSession)entity);
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
                _context.Sessions.Update((RequestRunSession)entity);
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
                _context.Sessions.Remove((RequestRunSession)entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while deleting entity from the database. Error type: {ex}; message: {ex.Message}");
                return false;
            }

            return true;
        }

        public UserPreferences GetPreferences(RequestRunSession session)
        {
            return _context.Sessions.FirstOrDefault(s => s.Id == session.Id).UserPreferences;
        }
    }
}

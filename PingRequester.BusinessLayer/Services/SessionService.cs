using PingRequester.Data;
using PingRequester.Data.Entities;

namespace PingRequester.BusinessLayer.Services
{
    public class SessionService : IEntityService<RequestRunSession>
    {
        private readonly Func<MyDbContext> _contextFactory;

        public SessionService(Func<MyDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public RequestRunSession? GetById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Sessions.FirstOrDefault(s => s.Id == id);
            }
        }

        public IEnumerable<RequestRunSession> GetAll()
        {
            using (var context = _contextFactory())
            {
                return context.Sessions.ToList();
            }
        }

        public bool Add(RequestRunSession entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Sessions.Add(entity);
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

        public bool Update(RequestRunSession entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Sessions.Update(entity);
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

        public bool Delete(RequestRunSession entity)
        {
            if (entity == null)
            {
                return false;
            }

            try
            {
                using (var context = _contextFactory())
                {
                    context.Sessions.Remove(entity);
                    context.SaveChanges();
                }
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
            using (var context = _contextFactory())
            {
                return context.Sessions.FirstOrDefault(s => s.Id == session.Id).UserPreferences;
            }
        }
    }
}

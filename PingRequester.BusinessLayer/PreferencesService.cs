using PingRequester.Data;
using PingRequester.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public bool Update(Entity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}

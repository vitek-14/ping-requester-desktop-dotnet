using PingRequester.Data.Base;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.BusinessLayer.Services
{
    internal interface IEntityService
    {
        public Entity? GetById(int id);
        public IEnumerable<Entity> GetAll();
        public bool Add(Entity entity);
        public bool Update(Entity entity);
        public bool Delete(Entity entity);
    }
}

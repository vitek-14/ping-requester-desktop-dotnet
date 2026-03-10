using PingRequester.Data.Base;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.BusinessLayer.Services
{
    internal interface IEntityService<TEntity> where TEntity : Entity
    {
        public TEntity? GetById(int id);
        public IEnumerable<TEntity> GetAll();
        public bool Add(TEntity entity);
        public bool Update(TEntity entity);
        public bool Delete(TEntity entity);
    }
}

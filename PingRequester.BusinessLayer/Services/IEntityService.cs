using PingRequester.Data.Base;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.BusinessLayer.Services
{
    /// <summary>
    /// Defines operations for managing entities, including CRUD operations.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity managed by the service, constrained to inherit from Entity.</typeparam>
    internal interface IEntityService<TEntity> where TEntity : Entity
    {
        /// <summary>
        /// Retrieves an entity by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        public TEntity? GetById(int id);
        /// <summary>
        /// Retrieves all entities of type TEntity.
        /// </summary>
        public IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Adds the specified entity to the database.
        /// </summary>
        /// <param name="entity"></param>
        public bool Add(TEntity entity);
        /// <summary>
        /// Updates the specified entity in the database.
        /// </summary>
        /// <param name="entity"></param>
        public bool Update(TEntity entity);
        /// <summary>
        /// Deletes specified entity from the database.
        /// </summary>
        /// <param name="entity"></param>
        public bool Delete(TEntity entity);
    }
}

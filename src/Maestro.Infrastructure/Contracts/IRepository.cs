using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Contracts
{
    /// <summary>
    /// Generic Repository contract for Dapper
    /// </summary>
    /// <typeparam name="TEntity">Database Entity Type</typeparam>
    public interface IRepository<TEntity>
    {
      
        /// <summary>
        /// All instances.
        /// </summary>
        /// <param name="page">The identifier.</param>
        /// <param name="pageCount">The identifier.</param>
        /// <returns>Records from the table based on the page number and page count</returns>
        Task<IList<TEntity>> AllAsync(int page, int pageCount);
        /// <summary>
        /// All instances.
        /// </summary>
        /// <param name="page">The identifier.</param>
        /// <param name="pageCount">The identifier.</param>
        /// <returns>Records from the table based on the page number and page count</returns>
        Task<List<TEntity>> SelectAllAsync();

        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> FindByIdAsync(int id);
        /// <summary>
        /// Finds the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<TEntity> FindByGuidIdAsync(Guid id);
        /// <summary>
        /// Finds specified data from stored procedure
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<List<TEntity>> FindByStoredProcAsyncList(string storedProcedure, object parameters = null);
        /// <summary>
        /// Finds specified data from stored procedure 
        /// </summary>
        /// <param name="storedProcedure"></param>
        /// <param name="parameters"></param>
        /// <returns>Single</returns>
        Task<TEntity> FindByStoredProcAsyncSingle(string storedProcedure, object parameters = null);
        /// <summary>
        /// Adds the specified entity return guid.
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task<Guid> AddAsync(TEntity entity);

        /// <summary>
        /// Inserts the specified entity return int.
        /// </summary>
        /// <param name="entity">The entity.</param>
       
        Task<int> InsertAsyncReturnById(TEntity entity);

        /// <summary>
        /// Inserts the specified entity return Entity.
        /// </summary>
        /// <param name="entity">The entity.</param>

        Task<TEntity> InsertAsyncReturnByEntity(TEntity entity);
      

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void RemoveAsync(TEntity entity);

        /// <summary>
        /// Removes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void RemoveAsync(Guid id);

        /// <summary>
        /// Removes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void RemoveAsync(int id);
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Entity</returns>
        Task<TEntity> UpdateAsnycReturnByEntity(TEntity entity);
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// 
        void UpdateAsync(TEntity entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>Entity</returns>
        Task<int> UpdateAsnycReturnById(TEntity entity);


    }
}

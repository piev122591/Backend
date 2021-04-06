

namespace Maestro.Infrastructure.Contracts
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the device repository.
        /// </summary>
        /// <value>
        /// The device repository.
        /// </value>
        IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class;

        /// <summary>
        /// Begins the transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits this instance.
        /// </summary>
        void Commit();

        /// <summary>
        /// Releases Unmanaged resources.
        /// </summary>
        void Dispose();

    }
}

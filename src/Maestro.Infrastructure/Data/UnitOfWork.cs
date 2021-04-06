using Maestro.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Maestro.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IDbConnection connection;
        private IDbTransaction transaction;

        private bool disposed;
        /// <summary>
        /// The repositories
        /// </summary>
        private Dictionary<Type, object> repositories;

        public UnitOfWork(IConnectionFactory connectionFactory)
        {
            this.connection = connectionFactory.Connection;
        }


        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (this.repositories == null)
            {
                this.repositories = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);

            if (!this.repositories.ContainsKey(type))
            {
                this.repositories[type] = new Repository<TEntity>(transaction);
            }

            return (IRepository<TEntity>)this.repositories[type];
        }
        public void BeginTransaction()
        {
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                transaction.Dispose();
                transaction = connection.BeginTransaction();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                        transaction = null;
                    }
                    if (connection != null)
                    {
                        connection.Dispose();
                        connection = null;
                    }
                }
                disposed = true;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}

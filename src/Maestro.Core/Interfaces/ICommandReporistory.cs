using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Core.Interfaces
{
    public interface ICommandReporistory<T> where T : class
    {
        Task<T> AddAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class;
        Task<int> AddAsyncReturnById<TEntity>(TEntity entity) where TEntity : class;
        Task<T> UpdateAsyncReturnByEntity<TEntity>(TEntity entity) where TEntity : class;
        Task<int> UpdateAsyncReturnById<TEntity>(TEntity entity) where TEntity : class;
        Task<T> DeleteAsync<TEntity>(TEntity entity) where TEntity : class;
    }
}

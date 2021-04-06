
using Dapper;
using Maestro.Infrastructure.Contracts;
using Maestro.Infrastructure.SQLHelpers;
using Maestro.Shared.DatabaseAttributes.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Infrastructure.Data
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        public Repository(IDbTransaction transaction) : base(transaction)
        {

        }

        public async Task<Guid> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<T>> AllAsync(int page, int pageCount)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindByGuidIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            var query = QueryBuilder.GetFindQuery<T>();

            var paramObject = new ExpandoObject();

            paramObject.TryAdd(QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name, id);

            var record = await Connection.QueryFirstOrDefaultAsync<T>(query, param: paramObject, transaction: Transaction);

            return record;
        }

        public async Task<List<T>> FindByStoredProcAsyncList(string storedProcedure, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> FindByStoredProcAsyncSingle(string storedProcedure, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(T));

            var paramObject = new ExpandoObject();

            foreach (var property in QueryBuilder.GetPropertiesWithAttribute<T>(typeof(DapperInsertAttribute)))
            {
                paramObject.TryAdd(property.Name, property.GetValue(entity));
            }

            return await Connection.ExecuteScalarAsync<int>(QueryBuilder.GetInsertQuery<T>(), paramObject, Transaction);

        }

        public async Task<T> InsertAsyncReturnByEntity(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(T));

            var paramObject = new ExpandoObject();

            foreach (var property in QueryBuilder.GetPropertiesWithAttribute<T>(typeof(DapperInsertAttribute)))
            {
                paramObject.TryAdd(property.Name, property.GetValue(entity));
            }

            var scopeId = await Connection.QuerySingleAsync<int>(QueryBuilder.GetInsertQuery<T>(), paramObject, Transaction);

            var entityId = QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault();

            entityId.SetValue(entity, scopeId);

            return entity;
        }

        public async Task<int> InsertAsyncReturnById(T entity)
        {

           if (entity == null)
                throw new ArgumentNullException(nameof(T));

            var paramObject = new ExpandoObject();

            foreach (var property in QueryBuilder.GetPropertiesWithAttribute<T>(typeof(DapperInsertAttribute)))
            {
                paramObject.TryAdd(property.Name, property.GetValue(entity));
            }

            return await Connection.ExecuteScalarAsync<int>(QueryBuilder.GetInsertQuery<T>(), paramObject, Transaction);
            
        }


        public async void RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async void RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async void RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> SelectAllAsync()
        {
            var records = await Connection.QueryAsync<T>(QueryBuilder.SelectAll<T>(), transaction: Transaction);

            return records.ToList();
        }

        public async Task<T> UpdateAsnyc(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsnycReturnByEntity(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(T));

            var paramObject = new ExpandoObject();
            var keyName = QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;
            var keyValue = QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().GetValue(entity);
            paramObject.TryAdd(keyName, keyValue);

            foreach (var property in QueryBuilder.GetPropertiesWithAttribute<T>(typeof(DapperUpdateAttribute)))
            {
                paramObject.TryAdd(property.Name, property.GetValue(entity));
            }

            await Connection.ExecuteScalarAsync<T>(QueryBuilder.GetUpdateQuery<T>(), paramObject, Transaction);
            return entity;
        }

        public async Task<int> UpdateAsnycReturnById(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(T));

            var paramObject = new ExpandoObject();
            var keyName = QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;
            var keyValue = QueryBuilder.GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().GetValue(entity);
            paramObject.TryAdd(keyName, keyValue);

            foreach (var property in QueryBuilder.GetPropertiesWithAttribute<T>(typeof(DapperUpdateAttribute)))
            {
                paramObject.TryAdd(property.Name, property.GetValue(entity));
            }

            return await Connection.ExecuteScalarAsync<int>(QueryBuilder.GetUpdateQuery<T>(), paramObject, Transaction);
            
        }



        public async void UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

//using Maestro.Shared.Kernel.Attributes;
using Maestro.Shared.DatabaseAttributes.Dapper;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Maestro.Infrastructure.SQLHelpers
{
    public class QueryBuilder
    {    
        /// <summary>
        /// Builds query
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <returns></returns>
        public static string FindById<T>()
        {
            var keyProperty = GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;

            var tableName = GetTableName<T>();

            if (keyProperty == null)
                throw new KeyNotFoundException($"Key property not found for table {tableName}");

            return $"SELECT * FROM {tableName} WHERE {keyProperty} = @{keyProperty}";

        }
        /// <summary>
        /// Builds generic dapper find query
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <returns></returns>
        public static string FindByParams<T>()
        {
            var keyProperty = GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault();

            var tableName = GetTableName<T>();

            if (keyProperty == null)
                throw new KeyNotFoundException($"Key property not found for table {tableName}");

            return $"SELECT * FROM {tableName} WHERE {keyProperty} = @{keyProperty}";
        }


        /// <summary>
        /// Builds select query for the table.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <returns>Select query</returns> 
        public static string SelectAll<T>() where T : class
        {
            var schema = GetDomainSchemaAttribute<T>();

            string query = $"SELECT {GetColumns<T>()} FROM {schema}{GetTableName<T>()}";

            return query;

        }
        
        /// <summary>
        /// Builds generic dapper find query
        /// </summary>
        /// <typeparam name="T">Type of the model</typeparam>
        /// <returns></returns>
        /// 
        public static string GetFindQuery<T>()
        {
            var keyProperty = GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;

            var Schema = GetDomainSchemaAttribute<T>();

            var tableName = GetTableName<T>();

            if (keyProperty == null)
                throw new KeyNotFoundException($"Key property not found for table {tableName}");

            return $"SELECT * FROM {Schema}{tableName} WHERE {keyProperty} = @{keyProperty}";
        }

        /// <summary>
        /// Builds select query for the table.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <returns>Select query</returns>
        public static string GetSelectQuery<T>()
        {
            string query = $"SELECT * FROM {GetTableName<T>()}";
            return query;
        }

        /// <summary>
        /// Builds a insert query for the model
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <returns>Insert query</returns>
        public static string GetInsertQuery<T>()
        {

            var Schema = GetDomainSchemaAttribute<T>();

            var insertProperties = GetPropertiesWithAttribute<T>(typeof(DapperInsertAttribute));

            var insertQueryBuilder = new StringBuilder($"INSERT INTO {Schema}{GetTableName<T>()}(");

            var insertPropertiesBuilder = new StringBuilder();

            bool appendComma = false;

            foreach (var property in insertProperties)
            {
                insertQueryBuilder.Append($"{(appendComma ? "," : string.Empty)} {property.Name}");

                insertPropertiesBuilder.Append($"{(appendComma ? "," : string.Empty)} @{property.Name}");

                appendComma = true;
            }

            insertQueryBuilder.Append($") VALUES({insertPropertiesBuilder.ToString()}); SELECT SCOPE_IDENTITY()");

            return insertQueryBuilder.ToString();
        }



        public static string GetUpdateQuery<T>()
        {
            var keyProperty = GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;

            var Schema = GetDomainSchemaAttribute<T>();

            var updateProperties = GetPropertiesWithAttribute<T>(typeof(DapperUpdateAttribute));

            var updateQueryBuilder = new StringBuilder($"UPDATE {Schema}{GetTableName<T>()} SET");

            //var updatePropertiesBuilder = new StringBuilder();

            bool appendComma = false;

            foreach (var property in updateProperties)
            {
                updateQueryBuilder.Append($"{(appendComma ? "," : string.Empty)} {property.Name} = @{property.Name}");

                appendComma = true;
            }

            if (keyProperty == null)
                throw new KeyNotFoundException($"Key property not found for table {GetTableName<T>()} ");
            updateQueryBuilder.Append($" WHERE {keyProperty} = @{keyProperty}");

            return updateQueryBuilder.ToString();

        }


        public static string GetDeleteQuery<T>()
        {
            var keyProperty = GetPropertiesWithAttribute<T>(typeof(KeyAttribute)).FirstOrDefault().Name;

            var Schema = GetDomainSchemaAttribute<T>();

            var tableName = GetTableName<T>();

            if (keyProperty == null)
                throw new KeyNotFoundException($"Key property not found for table {tableName}");

            return $"DELETE FROM {Schema}{tableName} WHERE {keyProperty} = @{keyProperty}";


        }

        /// <summary>
        /// Gets the table based on model name. Assumes table name is model name followed by 's'
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <returns>Table name</returns>
        private static string GetTableName<T>() => $"{typeof(T).Name}";
        /// <summary>
        /// Get Entity Columns based on Db Column Attribute
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static string GetColumns<T>() where T : class
        {
            string query = string.Empty;

            var selectProperties = GetPropertiesWithAttribute<T>(typeof(DbColumnAttribute));
            var columnBuilder = new StringBuilder();

            bool appendComma = false;

            foreach (var property in selectProperties)
            {
                columnBuilder.Append($"{(appendComma ? "," : string.Empty)} {property.Name}");

                appendComma = true;
            }
            query = columnBuilder.ToString();

            return query;
        }
        /// <summary>
        /// Get Domain Schema
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static string GetDomainSchemaAttribute<T>()
        {

            var domainAttribute = typeof(T).GetCustomAttribute<DBSchema>(true);
            if (domainAttribute != null)
            {
                return string.Concat(domainAttribute.Name, ".");
            }
            return string.Empty;
        }
        /// <summary>
        /// Gets all properties on which <paramref name="attributeType"/> is defined. For eg. <see cref="DapperInsertAttribute"/>.
        /// </summary>
        /// <typeparam name="T">Model type</typeparam>
        /// <param name="attributeType">Attribute type</param>
        /// <returns>Property list</returns>
        public static IEnumerable<PropertyInfo> GetPropertiesWithAttribute<T>(Type attributeType)
        {
            return typeof(T).GetProperties().Where(property => Attribute.IsDefined(property, attributeType)).OrderBy(x => x.Name);
        }


    }
}

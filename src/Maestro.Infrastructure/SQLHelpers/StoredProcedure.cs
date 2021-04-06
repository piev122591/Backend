using Dapper;
using Maestro.Shared.DatabaseAttributes.StoredProcedure;
using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Maestro.Infrastructure.SQLHelpers
{
    public class StoredProcedure
    {
        public string StoredPocedureName { get; set; }

        public StoredProcedure()
        {

        }

        public static DynamicParameters AddParameters<T>(T viewModel) where T : class
        {

            if (viewModel == null)
                throw new NullReferenceException(nameof(T));

            var parameters = new DynamicParameters();

            var obj = viewModel.GetType().GetProperties();

            foreach (PropertyInfo property in obj)
            {
                var attributes = property.GetCustomAttributes(false);

                var modelColumn = attributes.FirstOrDefault(a => a.GetType() == typeof(StoredProcedureParameterAttribute));

                var dbColumn = modelColumn as StoredProcedureParameterAttribute;

                if (modelColumn != null || dbColumn != null)
                {
                    var propertyValue = property.GetValue(viewModel);

                    var parameterName = string.Concat("@", dbColumn.Name);

                    var value = GetParamterValue(propertyValue);

                    var dbType = GetDbType(propertyValue, property);

                    parameters.Add(name: parameterName, value: value, dbType: dbType);

                }
            }


            return parameters;

        }

        private static DbType GetDbType(object propertyValue, PropertyInfo property)
        {

            var dbType = (propertyValue != null ? GetPropertyDBType(propertyValue) : GetPropertyDBType(property));

            return dbType;
        }

        private static object GetParamterValue(object value)
        {

            //var sqlParameterValue = new object();

            //sqlParameterValue = (value != null ? value : DBNull.Value);

            return (value != null ? value : DBNull.Value);
        }

        private static DbType GetPropertyDBType<T>(T property)
        {

            if (property != null)
            {

                if (property.GetType() == typeof(Int32))
                    return DbType.Int32;

                if (property.GetType() == typeof(Guid))
                    return DbType.Guid;

                if (property.GetType() == typeof(String))
                    return DbType.String;

                if (property.GetType() == typeof(Boolean))
                    return DbType.Boolean;

                if (property.GetType() == typeof(DateTime))
                    return DbType.Date;

                if (property.GetType() == typeof(Decimal))
                    return DbType.Decimal;
            }

            return DbType.Object;
        }

        private DbType GetPropertyDBType(PropertyInfo property)
        {
            if (property != null)
            {
                if (property.PropertyType == typeof(Int32))
                    return DbType.Int32;

                if (property.PropertyType == typeof(Guid))
                    return DbType.Guid;

                if (property.PropertyType == typeof(String))
                    return DbType.String;

                if (property.PropertyType == typeof(Boolean))
                    return DbType.Boolean;

                if (property.PropertyType == typeof(DateTime))
                    return DbType.Date;

                if (property.PropertyType == typeof(DateTime?))
                    return DbType.Date;

                if (property.PropertyType == typeof(Decimal))
                    return DbType.Decimal;
            }

            return DbType.Object;
        }

    }
}

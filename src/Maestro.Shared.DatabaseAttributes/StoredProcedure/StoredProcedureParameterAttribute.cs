using System;

namespace Maestro.Shared.DatabaseAttributes.StoredProcedure
{
    /// <summary>
    /// This attribute is used to indicate Dapper to select property in filtering query
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class StoredProcedureParameterAttribute : Attribute
    {
        public string Name { get; private set; }

        public StoredProcedureParameterAttribute(string name)
        {
            this.Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Shared.DatabaseAttributes.Dapper
{ 
    /// <summary>
    /// This attribute is used to indicate Dapper to select property in the Insert query
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DapperInsertAttribute : Attribute
    {
    }
}

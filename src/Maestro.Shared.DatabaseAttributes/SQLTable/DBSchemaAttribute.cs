using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Shared.DatabaseAttributes.SQLTable
{
   [AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    
    public class DBSchema : Attribute
    { 
        public string Name { get; private set; }

        public DBSchema(string name)
        {

            this.Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Shared.DatabaseAttributes.SQLTable
{

    public class DbColumnAttribute : Attribute
    {
        public string Name { get; private set; }

        public DbColumnAttribute(string name)
        {
            this.Name = name;
        }


    }
}

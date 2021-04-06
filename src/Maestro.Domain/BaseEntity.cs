using Maestro.Shared.DatabaseAttributes.Dapper;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain
{
    public abstract class BaseEntity
    {
        [DbColumn("CreatedBy")]
        [DapperInsert]
        [DapperUpdate]
        public string CreatedBy { get; set; }
        [DbColumn("CreatedDate")]
        [DapperInsert]
        [DapperUpdate]
        public DateTime CreatedDate { get; set; }
        [DbColumn("LastModifiedBy")]
        [DapperInsert]
        [DapperUpdate]
        public string LastModifiedBy { get; set; }
        [DbColumn("LastModifiedDate")]
        [DapperInsert]
        [DapperUpdate]
        public DateTime? LastModifiedDate { get; set; }


        //[DbColumn("IsActive")]
        //[DapperInsert]
        //[DapperUpdate]
        //public bool IsActive { get; set; }
    }
}

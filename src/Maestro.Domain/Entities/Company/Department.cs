using Maestro.Domain.Entities.Users;
using Maestro.Shared.DatabaseAttributes.Dapper;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Maestro.Domain.Entities.Company
{
    [DBSchema("company")]
    public class Department : BaseEntity
    {
        [Key()]
        [DbColumn("DepartmentId")]      
        public int DepartmentId { get; set; }
        [DapperInsert]
        [DapperUpdate]
        [DbColumn("DepartmentName")]   
        public string DepartmentName { get; set; }
     
        public ICollection<UserProfile> UserProfile { get; set; }
    }
}

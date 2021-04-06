using Maestro.Domain.Entities.Company;
using Maestro.Shared.DatabaseAttributes.Dapper;
using Maestro.Shared.DatabaseAttributes.SQLTable;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Maestro.Domain.Entities.Users
{
    [DBSchema("user")]
    public class UserProfile : BaseEntity
    {
        [Key()]
        [DbColumn("UserId")]
        public int UserId { get; set; }
        [DbColumn("UserName")]
        [DapperInsert]
        [DapperUpdate]
        public string UserName { get; set; }
        [DbColumn("PasswordHash")]
        [DapperInsert]
        [DapperUpdate]
        public byte[] PasswordHash { get; set; }
        [DbColumn("PasswordSalt")]
        [DapperInsert]
        [DapperUpdate]
        public byte[] PasswordSalt { get; set; }
        [DbColumn("TenantId")]
        [DapperInsert]
        [DapperUpdate]
        public Guid TenantId { get; set; }
        [DbColumn("FirstName")]
        [DapperInsert]
        [DapperUpdate]
        public string FirstName { get; set; }
        [DbColumn("MiddleName")]
        [DapperInsert]
        [DapperUpdate]
        public string MiddleName { get; set; }
        [DbColumn("LastName")]
        [DapperInsert]
        [DapperUpdate]
        public string LastName { get; set; }
        [DbColumn("Email")]
        [DapperInsert]
        [DapperUpdate]
        public string Email { get; set; }
        [DbColumn("DepartmentId")]
        [DapperInsert]
        [DapperUpdate]
        public int DepartmentId { get; set; }
      
        public Department Department { get; set; }

    }
}


using Maestro.Domain.Entities.Company;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Users
{
    [DBSchema("user")]
    public class UsersInGroup : BaseEntity
    {
        public int MyProperty { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        //public bool IsActive { get; set; }
        public MainList MainList { get; set; }
        public UserGroup UserGroup { get; set; }

    }
}

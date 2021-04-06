using Maestro.Domain.Admin.Users;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{

    [DBSchema("app")]
    public class UserGroupDefaultPermission : BaseEntity
    {
        public int UserGroupPermissionId { get; set; }
        public int UserGroupId { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}

using Maestro.Domain.Entities.Users;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{

    [DBSchema("app")]
    public class UserPermission : BaseEntity
    {
        public int UserPermissionId { get; set; }
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}

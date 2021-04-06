
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{
    [DBSchema("app")]
    public class Permission : BaseEntity
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionDescription { get; set; }
        public int PermissionGroupId { get; set; }
        public PermissionGroup PermissionGroup { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
        public ICollection<UserGroupDefaultPermission> UserGroupDefaultPermission { get; set; } 

    }
}

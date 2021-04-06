
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{
    [DBSchema("app")]
    public class PermissionGroup : BaseEntity
    {
        public int PermissionGroupId { get; set; }
        public string PermissionGroupName { get; set; }
        public ICollection<Permission> Permission { get; set; }
    }
}

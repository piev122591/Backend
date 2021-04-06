
using Maestro.Domain.Admin.App;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Users
{
    [DBSchema("user")]
    public class UserGroup : BaseEntity
    {
        public int UserGroupId { get; set; }
        public string UserGroupName { get; set; }
        public ICollection<UsersInGroup> UsersInGroup { get; set; }
        public ICollection<UserGroupDefaultPermission> UserGroupDefaultPermission { get; set; }

    }
}

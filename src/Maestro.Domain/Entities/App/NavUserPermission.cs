
using Maestro.Domain.Entities.Users;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{

    [DBSchema("app")]
    public class NavUserPermission : BaseEntity
    {
        public int NavUserPermissionId { get; set; }
        public int UserId { get; set; }
        public int NavPermissionId { get; set; }
        public NavPermission NavPermission { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}

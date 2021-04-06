using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{

    [DBSchema("app")]
    public class NavPermission : BaseEntity
    {
        public int NavPermissionId { get; set; }
        public string NavPermissionName { get; set; }
        public string NavPermissionDescription { get; set; }
        public int NavLinkId { get; set; }
        public NavLink NavLink { get; set; }
        public ICollection<NavUserPermission> NavUserPermission { get; set; }
        public ICollection<NavLinkDefaultPermission> NavLinkDefaultPermission { get; set; }



    }
}

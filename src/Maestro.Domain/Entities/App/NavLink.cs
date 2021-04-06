using Maestro.Shared.DatabaseAttributes.Dapper;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Maestro.Domain.Admin.App
{
    [DBSchema("app")]
    public class NavLink : BaseEntity
    {
        [Key()]
        [DbColumn("NavLinkId")]
        public int NavLinkId { get; set; }

        [DbColumn("NavLinkName")]
        [DapperInsert]
        [DapperUpdate]
        public string NavLinkName { get; set; }

        [DbColumn("ParentLinkId")]
        [DapperInsert]
        [DapperUpdate]
        public int ParentLinkId { get; set; }

        [DbColumn("IsParent")]
        [DapperInsert]
        [DapperUpdate]
        public bool IsParent { get; set; }

        [DbColumn("Icon")]
        [DapperInsert]
        [DapperUpdate]
        public string Icon { get; set; }

        public ICollection<NavPermission> NavPermission { get; set; }



    }
}

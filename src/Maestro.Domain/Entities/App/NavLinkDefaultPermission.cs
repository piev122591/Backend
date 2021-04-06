
using Maestro.Domain.Entities.Company;
using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.App
{
    [DBSchema("app")]
    public class NavLinkDefaultPermission : BaseEntity
    {
        public int NavlinkDefaultPermissionId { get; set; }
        public int DepartmentId { get; set; }
        public int NavPermissionId { get; set; }
        public NavPermission NavPermission { get; set; }
        public Department Department { get; set; }


    }
}

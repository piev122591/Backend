using Maestro.Core.Mappings;
using Maestro.Domain;
using Maestro.Domain.Entities.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.DepartmentFeature.Command.AddDepartment
{
    public class AddDepartmentDTO : BaseEntity, IMapDestination<Department>
    {
        public string DepartmentName { get; set; }
    }
}

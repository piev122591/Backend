using Maestro.Core.Mappings;
using Maestro.Domain.Entities.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.DepartmentFeature.Queries.GetAllDepartment
{
    public class GetAllDepartmentVM : IMapSource<Department>
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

    }
}

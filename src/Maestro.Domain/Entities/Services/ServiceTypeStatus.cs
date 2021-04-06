using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Services
{
    public class ServiceTypeStatus : BaseEntity
    {
        public int ServiceTypeStatusId { get; set; }
        public string ServiceTypeStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}

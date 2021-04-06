using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Services
{
    public class ServiceType : BaseEntity
    {
        public int ServiceTypeId { get; set; }
        public string ServiceTypeDescription { get; set; }
        public int ServiceTypeStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Services
{
    public class ServiceSubType : BaseEntity
    {
        public int ServiceSubTypeId { get; set; }
        public string ServiceTypeDescription { get; set; }
        public int ServiceTypeId { get; set; }
        public int ServiceSubTypeStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

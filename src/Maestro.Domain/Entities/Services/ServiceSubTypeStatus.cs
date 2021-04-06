using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Services
{
    public class ServiceSubTypeStatus
    {
        public int ServiceSubTypeStatusId { get; set; }
        public string ServiceSubTypeStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}

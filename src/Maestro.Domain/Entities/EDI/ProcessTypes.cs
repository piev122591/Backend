using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.EDI
{
   public class ProcessTypes : BaseEntity
    {
        public int ProcessTypeId { get; set; }
        public string ProcessTypeName { get; set; }
        public int VendorId { get; set; }
        public int ProcessTypeStatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

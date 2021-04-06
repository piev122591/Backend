using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.EDI
{
    public class ProcessTypeStatus : BaseEntity
    {
        public int ProcessTypeStatusId { get; set; }
        public string ProcessTypeStatusDescription { get; set; }
        public bool IsDeleted { get; set; }
    }
}

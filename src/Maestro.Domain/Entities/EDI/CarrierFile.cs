using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.EDI
{
    public class CarrierFile : BaseEntity
    {
        public int CarrierFileId { get; set; }
        public int VendorId { get; set; }
        public string FileName { get; set; }
        public int FileMonth { get; set; }
        public int FileYear { get; set; }
        public string TextDelimiter { get; set; }
        public string TextQualifier { get; set; }
        public int ProcessTypeId { get; set; }
        public bool IsDeleted { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Charges
{
    public class XREFCharges : BaseEntity
    {
        public int XrefId { get; set; }
        public string ChargeCodeDescription { get; set; }
        public int VendorId { get; set; }
        public int ChargeCodeId { get; set; }

    }
}

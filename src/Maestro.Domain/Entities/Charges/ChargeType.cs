using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Charges
{
    [DBSchema("charges")]
    public class ChargeType : BaseEntity
    {
        public int ChargeTypeId { get; set; }
        public string ChargeTypeDescription { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ChargeCode> ChargeCodes { get; set; }
    }
}

using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Charges
{
    [DBSchema("charges")]
    public class ChargeClassification : BaseEntity
    {
        public int ChargeClassificationId { get; set; }
        public string ClassificationDescription { get; set; }
        public int StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ChargeCode> ChargeCodes { get; set; }
    }
}

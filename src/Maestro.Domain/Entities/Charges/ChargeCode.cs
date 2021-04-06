using Maestro.Shared.DatabaseAttributes.SQLTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Admin.Charges
{
    [DBSchema("charges")]
    public class ChargeCode : BaseEntity
    {
        public int ChargeCodeId { get; set; }
        public int CarrierId { get; set; }
        public string ChargeDescription { get; set; }
        public int StatusId { get; set; }
        public int ChargeClassificationId { get; set; }
        public int ChargeTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public ChargeClassification ChargeClassification { get; set; }
        public ChargeType Type { get; set; }


    }
}

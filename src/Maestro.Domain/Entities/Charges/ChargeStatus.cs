using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities.Charges
{
    public class ChargeStatus : BaseEntity
    {
        public int ChargeStatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}

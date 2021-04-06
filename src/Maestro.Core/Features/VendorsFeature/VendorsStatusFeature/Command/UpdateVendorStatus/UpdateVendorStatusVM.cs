using Maestro.Core.Mappings;
using Maestro.Domain;
using Maestro.Domain.Entities.Vendor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Command.UpdateVendorStatus
{
    public class UpdateVendorStatusVM : BaseEntity,IMapSource<VendorStatus>
    {
        public int VendorStatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}

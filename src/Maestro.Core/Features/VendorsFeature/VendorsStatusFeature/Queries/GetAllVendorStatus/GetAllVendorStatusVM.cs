using Maestro.Core.Mappings;
using Maestro.Domain;
using Maestro.Domain.Entities.Vendor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.VendorsFeature.VendorsStatusFeature.Queries.GetAllVendorStatus
{
   public class GetAllVendorStatusVM : BaseEntity,IMapSource<VendorStatus>
    {
        public int VendorStatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}

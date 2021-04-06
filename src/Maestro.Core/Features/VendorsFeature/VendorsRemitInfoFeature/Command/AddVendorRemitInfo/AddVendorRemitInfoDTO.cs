using Maestro.Core.Mappings;
using Maestro.Domain;
using Maestro.Domain.Admin.Vendor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Features.VendorsFeature.VendorsRemitInfoFeature.Command.AddVendorRemitInfo
{
    public class AddVendorRemitInfoDTO : BaseEntity,IMapDestination<VendorRemitInfo>
    {
        public int RemitId { get; set; }
        public string POBox { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string zip { get; set; }
        public int Status { get; set; }
        public int VendorId { get; set; }
        public bool IsDeleted { get; set; }
    }
}

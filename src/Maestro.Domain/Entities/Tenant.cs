using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Entities
{
    public class Tenant
    {
        public Guid TenantId { get; set; }
        public Guid APIKey { get; set; }
        public string DBName { get; set; }
        public string TenantName { get; set; }

    }
}

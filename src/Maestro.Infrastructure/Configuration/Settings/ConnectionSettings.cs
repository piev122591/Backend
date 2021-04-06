using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Maestro.Infrastructure.Configuration.Settings
{
    public class ConnectionSettings
    {

        [Required]
        public string DefaultConnection { get; set; }
    }
}

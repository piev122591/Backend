﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Domain.Settings
{
    public class JTWSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }

    }
}

using Maestro.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Services
{
    public class DateAndTime : IDateAndTime
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}

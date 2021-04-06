using System;
using System.Collections.Generic;
using System.Text;

namespace Maestro.Core.Interfaces
{
    public interface IDateAndTime
    {
        DateTime UtcNow { get; }
    }
}

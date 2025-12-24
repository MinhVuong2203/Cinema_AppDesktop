using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Licensing
{
    public enum LicenseState
    {
        Activated = 1,
        Trial = 2,
        Expired = 3,
        SeatLimitReached = 4,
        Error = 99
    }
}

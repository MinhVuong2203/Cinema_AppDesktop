using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Licensing
{
    public sealed class LicenseResult
    {
        public LicenseState State { get; set; }
        public string Message { get; set; }

        public int TrialDaysLeft { get; set; }

        public Guid TenantId { get; set; }
        public int? MaxSeats { get; set; }
        public int? UsedSeats { get; set; }
        public DateTime? ExpiresAtUtc { get; set; }
    }
}

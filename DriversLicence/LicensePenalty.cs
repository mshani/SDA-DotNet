using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicence
{
    internal class LicensePenalty : Penalty
    {
        public DateTime? PenaltyDate { get; set; }
        public string? Notes { get; set; }
        public override string ToString()
        {
            return $"{base.Code}: {base.Description} ({PenaltyDate})";
        }
    }
}

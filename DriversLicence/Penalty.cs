using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicence
{
    internal class Penalty
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
        public int PointsReduction { get; set; }
        public int BlockDays { get; set; }
        public override string ToString()
        {
            return $"{Code}: {Description}";
        }
    }
}

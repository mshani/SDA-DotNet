using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasportExample
{
    internal abstract class RoadTransport : TrasportationMean
    {
        public bool HasWheels { get; set; }
        public bool IsPublic { get; set; }  
        public DateTime LastCheckedDate { get; set; }
        public virtual DateTime FindNextCheckDate()
        {
            var nextCheckDate = LastCheckedDate.AddYears(1);
            return nextCheckDate;
        }
    }
}


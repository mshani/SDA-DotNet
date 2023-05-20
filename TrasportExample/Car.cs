using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasportExample
{
    internal class Car : RoadTransport
    {
        public string PlateNumber { get; set; }
        public bool IsManual { get; set; }
        public bool IsRented { get; set; }
        public override DateTime FindNextCheckDate()
        {
            var nextCheckDate = base.LastCheckedDate.AddYears(2);
            return nextCheckDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasportExample
{
    internal class Bus : RoadTransport
    {
        public string PlateNumber { get; set; }
        public decimal TicketPrice { get; set;}
        public string Itenerar { get; set; }
        public override DateTime FindNextCheckDate()
        {
            var nextCheckDate = base.LastCheckedDate.AddMonths(6);
            return nextCheckDate;
        }
    }
}

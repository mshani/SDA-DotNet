using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasportExample
{
    internal abstract class TrasportationMean
    {
        public int SpeedLimit { get; set; }
        public int PassengerCapacity { get; set; }
        public string EngineType { get; set; }
    }
}

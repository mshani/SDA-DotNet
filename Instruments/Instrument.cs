using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    internal class Instrument
    {
        public string Type { get; private set; }
        public bool Clean { get; private set; }
        public Instrument(string type, bool clean)
        {
            this.Type = type;
            this.Clean = clean;
        }

        public void CleanInstrument()
        {
            this.Clean = true;
        }
    }
}

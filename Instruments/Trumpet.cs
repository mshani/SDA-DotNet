using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    internal class Trumpet : Instrument
    {
        public bool Oiled { get; private set; }
        public Trumpet(string type, bool clean, bool oiled): base(type, clean) 
        { 
            this.Oiled = oiled;
        }
    }
}

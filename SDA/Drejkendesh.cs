using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA
{
    internal class Drejkendesh
    {
        public double Brinja1 { get; set; }
        public double Brinja2 { get; set; }
        
        public Drejkendesh() { }

        public Drejkendesh(double brinja1)
        {
            Brinja1 = brinja1;
            Brinja2 = brinja1;
        }
        public Drejkendesh(double brinja1, double brinja2)
        {
            Brinja1 = brinja1;
            Brinja2 = brinja2;
        }

        public double LlogaritSiperfaqen()
        {
            return Brinja1 * Brinja2;
        }

        public double LlogaritPerimetrin()
        {
            return 2 * Brinja1 + 2 * Brinja2;
        }
    }
}

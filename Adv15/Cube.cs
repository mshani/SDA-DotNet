using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv15
{
    internal class Cube : Shape3D
    {
        public double Base { get; set; }
        public Cube(double b)
        {
            Base = b;
        }

        public override double CalculateArea()
        {
            var result = 6 * Math.Pow(Base, 2);
            return result;
        }

        public override double CalculatePerimeter()
        {
            return 12 * Base;
        }

        public override double CalculateVolume()
        {
            return  Math.Pow(Base, 3);
        }
    }
}

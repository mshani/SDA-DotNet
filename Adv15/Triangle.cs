using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv15
{
    internal class Triangle: Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public override double CalculateArea()
        {
            return Base * Height / 2;
        }

        public override double CalculatePerimeter()
        {
            return Base + Side1 + Side2;
        }
    }
}

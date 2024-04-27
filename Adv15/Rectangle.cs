using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv15
{
    internal class Rectangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            if (Base <= 0 || Height <= 0)
            {
                throw new ArgumentException("Invalid arguments");
            }
            return Base * Height;
        }
        public override double CalculatePerimeter()
        {
            if (Base <= 0 || Height <= 0)
            {
                throw new ArgumentException("Invalid arguments");
            }
            return 2 * Base + 2 * Height;
        }
    }
}

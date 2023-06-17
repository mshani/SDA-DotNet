using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv07
{
    internal class MoveDirection
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public MoveDirection(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv07
{
    internal class Point2D: IMovable
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(MoveDirection moveDirection)
        {
            this.x += moveDirection.x;
            this.y += moveDirection.y;
        }
    }
}

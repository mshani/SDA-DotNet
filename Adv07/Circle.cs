using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv07
{
    internal class Circle : IMovable
    {
        Point2D center;
        Point2D point;
        public Circle(Point2D center, Point2D point) {
            this.center = center;
            this.point = point;
        }

        public double GetRadius()
        {
            var radius = Math.Sqrt(Math.Pow(point.x - center.x, 2) + Math.Pow(point.y - center.y, 2));
            return radius;
        }
        public double GetPerimeter()
        {
            var radius = GetRadius();
            var parameter = 2 * Math.PI * radius;
            return parameter;
        }

        public double GetArea()
        {
            var radius = GetRadius();
            var s = Math.PI * Math.Pow(radius,2);
            return s;
        }

        public void Move(MoveDirection moveDirection)
        {
            center.Move(moveDirection);
            point.Move(moveDirection);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adv07
{
    internal class Circle : IMovable, IResizeble
    {
        Point2D center;
        Point2D point;
        public Circle(Point2D center, Point2D point) {
            this.center = center;
            this.point = point;
        }

        public double GetRadius()
        {
            var radius = Math.Sqrt(Math.Pow(point.x - center.x, 2) + 
                Math.Pow(point.y - center.y, 2));
            return radius;
        }
        public double GetPerimeter()
        {
            var radius = GetRadius();
            var perimeter = 2 * Math.PI * radius;
            return perimeter;
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

        public void Resize(double resizeFactor)
        {
            point.x *= resizeFactor;
            point.y *= resizeFactor;
        }

        public void PrintPoints()
        {
            Console.WriteLine($"center: {center.x},{center.y}");
            Console.WriteLine($"point: {point.x},{point.y}");
        }
    }
}

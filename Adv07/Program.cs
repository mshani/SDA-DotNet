using Adv07;

Point2D center = new Point2D { x = 0, y = 0 };
Point2D point = new Point2D { x = 0, y = 2 };
Circle circle = new Circle(center, point);

var radius =  circle.GetRadius();
Console.WriteLine("r: "+ radius);
var p = circle.GetPerimeter();
Console.WriteLine("p: "+ p);
var s = circle.GetArea();
Console.WriteLine("s: "+ s);

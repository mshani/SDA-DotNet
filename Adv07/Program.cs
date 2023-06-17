using Adv07;

Point2D center = new Point2D(0,0);
Point2D point = new Point2D(0,2);
Circle circle = new Circle(center, point);
circle.PrintPoints();

var radius =  circle.GetRadius();
Console.WriteLine("r: "+ radius);
var p = circle.GetPerimeter();
Console.WriteLine("p: "+ p);
var s = circle.GetArea();
Console.WriteLine("s: "+ s);

var moveDirection = new MoveDirection(-1, -1);
circle.Move(moveDirection);
circle.PrintPoints();
circle.Resize(2);
circle.PrintPoints();



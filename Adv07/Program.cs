using Adv07;

Point2D center = new Point2D(2,2);
Point2D point = new Point2D(5,2);
Circle circle = new Circle(center, point);
circle.PrintPoints();

var radius =  circle.GetRadius();
Console.WriteLine("r: "+ radius);
var p = circle.GetPerimeter();
Console.WriteLine("p: "+ p);
var s = circle.GetArea();
Console.WriteLine("s: "+ s);

var moveDirection = new MoveDirection(-2, -2);
circle.Move(moveDirection);
circle.PrintPoints();
circle.Resize(2);
circle.PrintPoints();

var radius2 = circle.GetRadius();
Console.WriteLine("r: " + radius2);
var p2 = circle.GetPerimeter();
Console.WriteLine("p: " + p2);
var s2 = circle.GetArea();
Console.WriteLine("s: " + s2);



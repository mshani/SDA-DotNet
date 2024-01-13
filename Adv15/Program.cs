using Adv15;

Cube cube = new Cube(4);
Console.WriteLine($"Area: {cube.CalculateArea()}");
Console.WriteLine($"Perimeter: {cube.CalculatePerimeter()}");
Console.WriteLine($"Volume: {cube.CalculateVolume()}");
cube.Fill(20);
cube.Fill(64);
cube.Fill(84);
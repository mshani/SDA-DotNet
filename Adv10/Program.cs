using Adv10;

Manufacturer toyota1 = new Manufacturer()
{
    Country = "Japan",
    Year = 1950,
    Name = "Toyota"
};

Manufacturer toyota2 = toyota1;

Manufacturer bmw1 = new Manufacturer()
{
    Country = "germany",
    Year = 1961,
    Name = "BMW"
};

Manufacturer bmw2 = new Manufacturer()
{
    Country = "Germany",
    Year = 1961,
    Name = "BMW"
};

Console.WriteLine($"comparing toyota1 againts null: {toyota1.Equals(null)}");

Console.WriteLine($"comparing toyota1 againts toyota2: {toyota1.Equals(toyota2)}");

Console.WriteLine($"comparing toyota1 againts bmw1: {toyota1.Equals(bmw1)}");

Console.WriteLine($"comparing bmw1 againts bmw2: {bmw1.Equals(bmw2)}");

Console.WriteLine($"Toyota1 {toyota1.GetHashCode()}");
Console.WriteLine($"Toyota2 {toyota2.GetHashCode()}");
Console.WriteLine($"BMW1 {bmw1.GetHashCode()}");
Console.WriteLine($"BMW2 {bmw2.GetHashCode()}");
using Adv18;

Zoo zoo = new Zoo();
zoo.AddAnimals("lion", 2);
zoo.AddAnimals("duck", 12);
zoo.AddAnimals("tiger", 3);
zoo.AddAnimals("wolf", 5);
zoo.AddAnimals("lion", 1);
zoo.AddAnimals("duck", 1);
zoo.AddAnimals("elephant", 1);

var animals = zoo.GetAnimalsCountSorted();
foreach(var e in animals)
{
    Console.WriteLine($"{e.Key}: {e.Value}");
}



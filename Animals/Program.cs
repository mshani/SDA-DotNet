using Animals;

Cat c = new Cat();
c.SetName("Mia");
c.SetWeight(3);

Cat c2 = new Cat();
c2.SetName("Luna");
c2.SetWeight(3.5);

Cat c3 = new Cat();
c3.SetName("Milo");
c3.SetWeight(5);

Dog d = new Dog();
d.SetName("Bubi");
d.SetWeight(6);

Dog d2 = new Dog();
d2.SetName("Boni");
d2.SetWeight(10);

List<Animal> animals = new List<Animal>();
animals.Add(c);
animals.Add(c2);
animals.Add(c3);
animals.Add(d); 
animals.Add(d2);

foreach(Animal a in animals)
{
    Console.WriteLine(a.ToString());
    a.Move();
    a.Speak();
    Console.WriteLine("-------------------");
}

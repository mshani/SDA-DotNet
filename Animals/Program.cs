using Animals;

Cat c = new Cat();
c.setName("Mia");
c.setWeight(3);

Cat c2 = new Cat();
c2.setName("Luna");
c2.setWeight(3.5);

Cat c3 = new Cat();
c3.setName("Milo");
c3.setWeight(5);

Dog d = new Dog();
d.setName("Bubi");
d.setWeight(6);

Dog d2 = new Dog();
d2.setName("Boni");
d2.setWeight(10);

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

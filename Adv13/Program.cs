using Adv13;

Computer c = new Computer()
{
    Company = "Dell",
    Model = "Latitude",
    Ram = 8192,
    GraphicsCard = "NVidia",
    Processor = "Core i7"
};

Console.WriteLine(c.ToString());

Laptop l = new Laptop
{
    Company = "Lenovo",
    Model = "Think pad",
    Ram = 8192,
    GraphicsCard = "AMD",
    Processor = "Core i10",
    Battery = 5000
};

Console.WriteLine(l.ToString());


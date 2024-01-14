using Adv24;

List<Car> cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Camry", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 },
            new Car { Make = "Ford", Model = "Mustang", Year = 2020 },
            new Car { Make = "Mercedes Benz", Model = "A Class", Year = 2020 }
        };

FileProcessor.SaveToFile("cars.json", cars);
List<Car> loadedCars = FileProcessor.LoadFromFile<List<Car>>("cars.json");

// Display the loaded list of cars
Console.WriteLine("Loaded Cars:");
foreach (var car in loadedCars)
{
    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
}


 


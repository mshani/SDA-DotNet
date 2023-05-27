using TrasportExample;

Car car = new Car()
{
    PlateNumber = "B00BS",
    IsManual = false,
    IsRented = false,
    IsPublic = false,
    HasWheels = true,
    SpeedLimit = 230,
    PassengerCapacity = 1,
    EngineType = EngineTypeEnum.Diesel,
    LastCheckedDate = new DateTime(2022, 3, 1)
};

Bus bus = new Bus()
{
    PlateNumber = "123KJL",
    IsPublic = true,
    HasWheels = true,
    EngineType = EngineTypeEnum.Eleclric,
    Itenerar = "Unaza",
    PassengerCapacity = 25,
    SpeedLimit = 80,
    TicketPrice = 40,
    LastCheckedDate = new DateTime(2023, 1, 30)
};

List<RoadTransport> transports = new List<RoadTransport>();
transports.Add(car);
transports.Add(bus);

foreach(var transport in transports)
{
    var nextCarCheckDate = transport.FindNextCheckDate();
    Console.WriteLine(nextCarCheckDate);
}
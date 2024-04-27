using Adv06;

var parcel = new Parcel
{
    xLength = 10,
    yLength = 30,
    zLength = 60,
    IsExpress = false,
    Weight = 22
};
Console.WriteLine($"Is valid: { parcel.Validate() }");

var parcel2 = new Parcel
{
    xLength = 30,
    yLength = 30,
    zLength = 60,
    IsExpress = true,
    Weight = 22
};

Console.WriteLine($"Is valid: {parcel2.Validate()}");

var parcel3 = new Parcel
{
    xLength = 30,
    yLength = 30,
    zLength = 60,
    IsExpress = false,
    Weight = 32
};

Console.WriteLine($"Is valid: {parcel3.Validate()}");

var parcel4 = new Parcel
{
    xLength = 30,
    yLength = 35,
    zLength = 39,
    IsExpress = false,
    Weight = 22
};

Console.WriteLine($"Is valid: {parcel4.Validate()}");

//Console.WriteLine(DateTime.Now.ToString());
//Console.WriteLine(DateTime.UtcNow.ToString());
//var rome = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTimeOffset.UtcNow, "Europe/Rome");
//Console.WriteLine(rome.ToString());
//var dt = rome.DateTime;
//Console.WriteLine(dt);
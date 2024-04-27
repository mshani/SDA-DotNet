//Aplikacioni do te menaxhoje patentat -- DriverLicence
//Krijim i nje patente te re 
//Shtim/heqje pikesh -- Add/RemovePoints(int points)
//Bllokim -- BlockLicence(DateTime blockDate, DateTime unBlockDate)
//Rinovim -- RenewLicence(int id, DateTime renewDate, DateTime expireDate)

using DriverLicence;

DriversLicense driversLicense = new DriversLicense
    ("1", "Soni", "Domi", 
    new DateTime(2002, 11, 20), 
    new DateTime(2020, 12, 20),
    new DateTime(2030, 12, 20), 
    "B2");

var penalty = new Penalty
{
    Code = "0001",
    Description = "Overlimit speed",
    PointsReduction = 10,
    BlockDays = 30,
};
var penalty2 = new Penalty
{
    Code = "0002",
    Description = "Wrong parking",
    PointsReduction = 0,
    BlockDays = 0,
};

driversLicense.AddPenalty(penalty2, new DateTime(2024, 4, 20), "Bllok");
Console.WriteLine(penalty2.ToString());
Console.WriteLine($"is active: {driversLicense.IsActive}");
driversLicense.AddPenalty(penalty, DateTime.Now, "Prane Myslym Shyrit");
Console.WriteLine(penalty.ToString());
Console.WriteLine($"is active: {driversLicense.IsActive}");


//driversLicense.RemovePoints(5);
//driversLicense.RemovePoints(15);
//driversLicense.RemovePoints(-5);
//driversLicense.AddPoints(2);
//driversLicense.AddPoints(12);
//driversLicense.BlockLicense(new DateTime(2024, 4, 1), new DateTime(2024, 4, 30));
//Console.WriteLine($"Is active: {driversLicense.IsActive}");
//driversLicense.AddPoints(12);
//Console.WriteLine($"Is active: {driversLicense.IsActive}");
//driversLicense.AddPoints(-9);



using WeatherForecast;
try
{
    HourlyForecast hourlyForecast1 = new HourlyForecast
    {
        Hour = 1,
        Temperature = 37,
        Humidity = 0.6,
        WindSpeed = 23,
        RainChances = 5,
        Description = WeatherEnum.Clear,
    };
    HourlyForecast hourlyForecast2 = new HourlyForecast
    {
        Hour = 2,
        Temperature = 34,
        Humidity = 0.5,
        WindSpeed = 30,
        RainChances = 10,
        Description = WeatherEnum.Clear,
    };
    HourlyForecast hourlyForecast3 = new HourlyForecast
    {
        Hour = 3,
        Temperature = 32,
        Humidity = 0.5,
        WindSpeed = 29,
        RainChances = 20,
        Description = WeatherEnum.Clear,
    };
    HourlyForecast hourlyForecast4 = new HourlyForecast
    {
        Hour = 4,
        Temperature = 36,
        Humidity = 0.7,
        WindSpeed = 29,
        RainChances = 28,
        Description = WeatherEnum.Cloudy,
    };
    HourlyForecast hourlyForecast5 = new HourlyForecast
    {
        Hour = 5,
        Temperature = 39,
        Humidity = 0.7,
        WindSpeed = 40,
        RainChances = 25,
        Description = WeatherEnum.Cloudy,
    };
    HourlyForecast hourlyForecast6 = new HourlyForecast
    {
        Hour = 6,
        Temperature = 42,
        Humidity = 0.6,
        WindSpeed = 29,
        RainChances = 36,
        Description = WeatherEnum.Cloudy,
    };
    HourlyForecast hourlyForecast7 = new HourlyForecast
    {
        Hour = 7,
        Temperature = 36,
        Humidity = 0.8,
        WindSpeed = 40,
        RainChances = 100,
        Description = WeatherEnum.Rainy,
    };
    HourlyForecast hourlyForecast8 = new HourlyForecast
    {
        Hour = 8,
        Temperature = 38,
        Humidity = 0.8,
        WindSpeed = 35,
        RainChances = 100,
        Description = WeatherEnum.Rainy,
    };

    DailyForecast dailyForecast = new DailyForecast(50, 34);

    dailyForecast.AddForecast(hourlyForecast1);
    dailyForecast.AddForecast(hourlyForecast2);
    dailyForecast.AddForecast(hourlyForecast3);
    dailyForecast.AddForecast(hourlyForecast4);
    dailyForecast.AddForecast(hourlyForecast5);
    dailyForecast.AddForecast(hourlyForecast6);
    dailyForecast.AddForecast(hourlyForecast7);
    dailyForecast.AddForecast(hourlyForecast8);

    int totalCasts = dailyForecast.HourlyForecasts.Count;
    Console.WriteLine($"Total forecasts: {totalCasts}");
    double averageTemperature = dailyForecast.GetAverageTemperature();
    Console.WriteLine($"Average temperature: {averageTemperature} fahrenheit ");
    double averageHumidity = dailyForecast.GetAverageHumidity();
    Console.WriteLine($"Average humidity: {averageHumidity * 100}%");
    double averageRainChances = dailyForecast.GetAverageRainChances();
    Console.WriteLine($"Average rain chances: {averageRainChances}%");
    double windSpeed = dailyForecast.GetAverageWindSpeed();
    Console.WriteLine($"Average wind speed: {windSpeed}km/h");
}
catch (Exception e)
{
    Console.WriteLine("Something went wrong");
}


//Skenari:
/*Duhet te mbahen te dhenat per parashikimin e motit ditor
 * Per kete eshte e nevojshme te ndertohen keto struktura:
 * 1. Klasa HourlyForcast e cila do te permbaje te dhanat e parashikimit per oren
 * 2. Klasa DailyForcast e cila do te permbaje te dhenat per parashikimin ditor si dhe listen e HourlyForcast
 * 3. Klasa Location e cila do te permbaje te dhenat e parashikimit ditor si dhe emrin e qytetit/shtetit. */
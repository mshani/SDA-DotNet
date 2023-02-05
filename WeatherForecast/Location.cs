using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    internal class Location
    {
        public string City { get; set; }
        public string CountryCode { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public double HightAboveSeaLevel { get; set; }
        public List<DailyForecast> DailyForecasts { get; set; } = new List<DailyForecast>();
    }
}

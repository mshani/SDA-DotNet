using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WeatherForecast
{  
    internal class HourlyForecast
    {
        private int hour = 0;
        private int rainChances = 0;
        private int windSpeed = 0;
        private double humidity = 0;
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentOutOfRangeException("hour");
                }
                hour = value;
            }
        }
        public int Temperature { get; set; }
        public int RainChances {
            get { return rainChances; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("rainChances");
                }
                rainChances = value;
            }
        }
        public int WindSpeed {
            get { return windSpeed; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("windSpeed");
                }
                windSpeed = value;
            }
        }
        public double Humidity {
            get { return humidity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("humidity");
                }
                humidity = value;
            }
        }
        public WeatherEnum Description { get; set; }
        public double GetHeatIndex()
        {
            double heatIndex = 
                - 42.379
                + (2.04901523 * Temperature) 
                + (10.14333127 * Humidity)
                - (0.22475541 * Temperature * Humidity) 
                - (6.83783 * Math.Pow(10, -3)* Math.Pow(Temperature, 2))
                - (5.481717 * Math.Pow(10, -2) * Math.Pow(Humidity,2))
                + (1.22874 * Math.Pow(10, -3) * Math.Pow(Temperature, 2) * Humidity)
                + (8.5282 * (Math.Pow(10, -4)) * Temperature * Math.Pow(Humidity, 2))
                - (1.99 * Math.Pow(10, -6) * Math.Pow(Temperature, 2) * Math.Pow(Humidity, 2));
            return heatIndex;
        }
    }
}

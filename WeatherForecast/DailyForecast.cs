using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    internal class DailyForecast
    {
        int maxTemp = 200;
        int minTemp = -100;
        List<HourlyForecast> hourlyForecasts = new List<HourlyForecast>();
        public DailyForecast(int maxTemp, int minTemp, DateTime? date = null)
        {
            if(maxTemp < minTemp)
            {
                throw new Exception("maxTemp cannot be lower than minTemp");
            }
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
            Date = date ?? DateTime.Now;
        }
        public DateTime Date { get; set; }
        public List<HourlyForecast> HourlyForecasts {
            get { return hourlyForecasts; }
        }
        public int MaxTemperature {
            get { return maxTemp; }
            set
            {
                if (value > 200)
                {
                    throw new ArgumentOutOfRangeException("maxTemp");
                }
                if (value < minTemp)
                {
                    throw new Exception("maxTemp cannot be lower than minTemp");
                }
                maxTemp = value;
            }
        }
        public int MinTemperature {
            get { return minTemp; }
            set
            {
                if (value < -100)
                {
                    throw new ArgumentOutOfRangeException("minTemp");
                }
                if (value > maxTemp)
                {
                    throw new Exception("maxTemp cannot be lower than minTemp");
                }
                minTemp = value;
            }
        }
        public double GetAverageTemperature(){
            double sum = 0;
            foreach( HourlyForecast h in HourlyForecasts)
            {
                sum += h.Temperature;
            }
            double average = sum / HourlyForecasts.Count;
            return average;
        }
        public double GetAverageWindSpeed(){
            double sum = 0;
            foreach (HourlyForecast h in HourlyForecasts)
            {
                sum += h.WindSpeed;
            }
            double average = sum / HourlyForecasts.Count;
            return average;
        }
        public double GetAverageHumidity(){
            double sum = 0;
            foreach (HourlyForecast h in HourlyForecasts)
            {
                sum += h.Humidity;
            }
            double average = sum / HourlyForecasts.Count;
            return average;
        }
        public double GetAverageRainChances(){
            double sum = 0;
            foreach (HourlyForecast h in HourlyForecasts)
            {
                sum += h.RainChances;
            }
            double average = sum / HourlyForecasts.Count;
            return average;
        }
        public void AddForecast(HourlyForecast forecast)
        {
            bool found = hourlyForecasts.Any(x => x.Hour == forecast.Hour);
            if (!found)
            {
                hourlyForecasts.Add(forecast);
            }
        }
    }
}

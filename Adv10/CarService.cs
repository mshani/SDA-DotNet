using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv10
{
    internal class CarService
    {
        public List<Car> Cars { get; private set; }
        public CarService() { 
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {          
            if (car != null){
                bool exists = false;
                //foreach (var element in Cars){
                //    if (element.Equals(car)){
                //        exists = true; 
                //        break;
                //    }
                //}
                exists = Cars.Any(element => element.Equals(car));
                if(!exists)
                    Cars.Add(car);
            }
        }
        public void RemoveCar(Car car)
        {
            if (car != null)
            {
                bool exists = false;
                //foreach (var element in Cars)
                //{
                //    if (element.Equals(car))
                //    {
                //        exists = true;
                //        break;
                //    }
                //}
                exists = Cars.Any(element => element.Equals(car));
                if (exists)
                    Cars.Remove(car);
            }
        }
        public void ListAll(List<Car> cars = null)
        {
            var toList = cars;
            if (cars == null){
                toList = Cars;
            }

            foreach (var car in toList)
            {
                Console.WriteLine($"{car.Name} {car.Model} {car.Year} {car.Price}");
            }
        }
        public List<Car> FindCarsByEngineType(EngineTypeEnum engineType)
        {
            var result = Cars
                .Where(x => x.EngineType == engineType)
                .ToList();
            return result;
        }
        public List<Car> FindCarsBeforeYear(int year)
        {
            var result = Cars
                        .Where(x => x.Year < year)
                        .ToList();
            return result;
        }
        public Car FindTheMostExpensiveCar()
        {
            var price = Cars.Max(x => x.Price);
            var result = Cars
                .Where(x => x.Price == price)
                .FirstOrDefault();
            return result;
        }
        public Car FindTheLeastExpensiveCar()
        {
            var price = Cars.Min(x => x.Price);
            var result = Cars
                .Where(x => x.Price == price)
                .FirstOrDefault();
            return result;
        }

    }
}

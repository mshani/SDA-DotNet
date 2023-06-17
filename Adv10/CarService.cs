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
        public List<Car> FindCarsWithAtLeastThreeManufactures()
        {
            var result = new List<Car>();
            //foreach(var car in Cars)
            //{
            //    var manufactures = car.Manufacturers.Count();
            //    if(manufactures >= 3) {               
            //        result.Add(car);
            //    }
            //}
            result = Cars
                .Where(x => x.Manufacturers.Count() >=3)
                .ToList();
            return result;
        }
        public List<Car> OrderListByModel(bool asending)
        {
            var result = new List<Car>();
            if (asending)
            {
                result = Cars.OrderBy(x => x.Model).ToList();
            }
            else
            {
                result = Cars.OrderByDescending(x => x.Model).ToList();
            }
            return result;
        }
        public bool FindInList(Car car)
        {
            if (car == null) return false;
            var result = Cars.Any(x => x.Equals(car));
            return result;
        }
        public List<Car> FindCarsByManufacturer(Manufacturer manufacturer)
        {
            var result =  new List<Car>();
            foreach (var car in Cars)
            {
                foreach(var m in car.Manufacturers)
                {
                    if (m.Equals(manufacturer))
                    {
                        result.Add(car);
                        break;
                    }
                }
            }
            //result = Cars.Where
            //        (x =>x.Manufacturers.Any(y => y.Equals(manufacturer)))
            //        .ToList();
            return result;
        }
        public List<Car> FindCarsByManufacturerYear(int year, string action)
        {
            var result = new List<Car>();
            foreach (var car in Cars)
            {
                foreach (var m in car.Manufacturers)
                {
                    switch (action)
                    {
                        case "=":
                            if (m.Year == year)
                            {
                                result.Add(car);
                                break;
                            } 
                        break;
                        case "<=":
                            if (m.Year <= year)
                            {
                                result.Add(car);
                                break;
                            }
                            break;
                        case ">=":
                            if (m.Year >= year)
                            {
                                result.Add(car);
                                break;
                            }
                            break;
                        case "!=":
                            if (m.Year != year)
                            {
                                result.Add(car);
                                break;
                            }
                            break;
                    } 
                }
            }
            return result;
        }
    }
}

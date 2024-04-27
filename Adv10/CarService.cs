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
                foreach (var element in Cars)
                {
                    if (element.Equals(car))
                    {
                        exists = true;
                        break;
                    }
                }
                //exists = Cars.Any(element => element.Equals(car));
                if(!exists)
                    Cars.Add(car);
            }
        }
        public void RemoveCar(Car car)
        {
            if (car != null)
            {
                bool exists = false;
                foreach (var element in Cars)
                {
                    if (element.Equals(car))
                    {
                        exists = true;
                        break;
                    }
                }
                //exists = Cars.Any(element => element.Equals(car));
                if (exists)
                    Cars.Remove(car);
            }
        }
        public void ListAll()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"{car.Name} {car.Model} {car.Year} {car.Price}");
            }
        }
        public List<Car> FindCarsByEngineType(EngineTypeEnum engineType)
        {
            var list = new List<Car>();
            foreach (var element in Cars)
            {
                if (element.EngineType == engineType)
                {
                    list.Add(element);
                }
            }
            //list = Cars
            //    .Where(x => x.EngineType == engineType)
            //    .ToList();
            return list;
        }
        public List<Car> FindCarsBeforeYear(int year)
        {
            var list = new List<Car>();
            foreach (var element in Cars)
            {
                if (element.Year < year)
                {
                    list.Add(element);
                }
            }
            //list = Cars
            //        .Where(x => x.Year < year)
            //        .ToList();
            return list;
        }
        public Car FindTheMostExpensiveCar()
        {
            var car = Cars.FirstOrDefault();
            if (car != null)
            {
                foreach (var element in Cars)
                {
                    if (car.Price < element.Price)
                    {
                        car = element;
                    }
                }
            }
            
            //var price = Cars.Max(x => x.Price);
            //car = Cars
            //    .Where(x => x.Price == price)
            //    .FirstOrDefault();
            //var result = Cars.OrderByDescending(x => x.Price).FirstOrDefault();
            //var result = Cars.OrderBy(x => x.Price).LastOrDefault();
            return car;
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
            foreach (var car in Cars)
            {
                var manufactures = car.Manufacturers.Count();
                if (manufactures >= 3)
                {
                    result.Add(car);
                }
            }
            //result = Cars
            //    .Where(x => x.Manufacturers.Count() >=3)
            //    .ToList();
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
            var result = false;
            foreach (var element in Cars)
            {
                if (element.Equals(car))
                {
                    result = true;
                    break;
                }                
            }
           // var result = Cars.Any(x => x.Equals(car));
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

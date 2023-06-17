using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv10
{
    internal class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public EngineTypeEnum EngineType { get; set; }

        public Car()
        {
            Manufacturers = new List<Manufacturer>();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (obj.GetType() != this.GetType())
                return false;

            var other = obj as Car;
            if (other?.Model.ToLower() == this.Model.ToLower()
                && other.Year == this.Year)
                return true;

            if (other?.GetHashCode() == this.GetHashCode())
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(Model, Year);
        }
    }
}

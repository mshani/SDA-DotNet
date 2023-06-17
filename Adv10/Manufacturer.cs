using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv10
{
    internal class Manufacturer
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (obj.GetType() != this.GetType()) 
                return false;

            var other = obj as Manufacturer;
            if (other.Name.ToLower() == this.Name.ToLower()
                && other.Year == this.Year
                && other.Country.ToLower() == this.Country.ToLower()) 
            {
                return true;
            }

            if(other.GetHashCode() == this.GetHashCode())
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            return System.HashCode.Combine(Country, Name, Year);
        }
    }
}

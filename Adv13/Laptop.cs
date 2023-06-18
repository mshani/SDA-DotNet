using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv13
{
    internal class Laptop : Computer
    {
        public int Battery { get; set; }
        public override int GetHashCode()
        {
            return System.HashCode.Combine(base.GetHashCode(), this.Battery);
        }
        public override string ToString()
        {
            return $"{base.ToString()} {this.Battery}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (obj.GetType() != this.GetType())
                return false;

            var other = obj as Laptop;
            if (!base.Equals(other)) return false;

            if (this.Battery == other.Battery)
                return true;
            else
                return false;
        }
    }
}

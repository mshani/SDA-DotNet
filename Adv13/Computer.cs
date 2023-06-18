using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Adv13
{
    internal class Computer
    {
        public string Processor { get; set; }
        public int Ram { get; set; }
        public string GraphicsCard { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{this.Company} {this.Model} {this.Processor} {this.Ram} {this.GraphicsCard}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (obj.GetType() != this.GetType())
                return false;

            var other = obj as Computer;
            if (other?.Model.ToLower() == this.Model.ToLower()
                && other.Processor.ToLower() == this.Processor.ToLower()
                && other.GraphicsCard.ToLower() == this.GraphicsCard.ToLower()
                && other.Company.ToLower() == this.Company.ToLower()
                && other.Ram == this.Ram)
                return true;

            if (other?.GetHashCode() == this.GetHashCode())
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return System.HashCode.Combine(Model,Processor, Ram, GraphicsCard, Company);
        }
    }
}

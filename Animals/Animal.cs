using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal abstract class Animal
    {
        string name;
        double weight;
        public abstract void Speak();
        public abstract void Move();

        public void SetName (string name){
            this.name = name;
        }

        public void SetWeight(double weight){
            this.weight = weight;
        }
        public override string ToString()
        {
           return $"Name: {name}, Weight {weight}kg";
        }
    }
}

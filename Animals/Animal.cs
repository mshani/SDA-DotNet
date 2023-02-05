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

        public void setName (string name){
            this.name = name;
        }

        public void setWeight(double weight){
            this.weight = weight;
        }
        public override string ToString()
        {
           return $"Name: {name}, Weight {weight}kg";
        }
    }
}

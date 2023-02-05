using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dog moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Ham ham");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Cat moving");
        }

        public override void Speak()
        {
            Console.WriteLine("Mjau mjau");
        }

        public void Pet()
        {
            Console.WriteLine("Cat petting");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherExample
{
    internal class Person
    {
        protected int age = -1;
        public virtual void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}



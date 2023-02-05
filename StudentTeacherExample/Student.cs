using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherExample
{
    internal class Student: Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I am a student");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherExample
{
    internal class Teacher: Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining");
        }
        public override void Greet()
        {
            Console.WriteLine("Hello, I am a teacher");
        }
    }
}

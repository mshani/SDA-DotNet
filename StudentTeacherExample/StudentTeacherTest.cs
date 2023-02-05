using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherExample
{
    internal class StudentTeacherTest
    {
        public void Execute()
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.Greet();
            student.SetAge(19);
            student.ShowAge();
            student.Study();
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

        }
    }
}

using System;
using System.Collections.Generic;

namespace SchoolProject.MVC.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int Age { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
    }
}

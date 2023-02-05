using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA
{
    internal class Person
    {
        private string name;
        private string surname;
        private string id;
        private char gender;
        private DateTime birthday;

        public Person(){}
        public Person(string name, string surname, string id, char gender, DateTime birthday){
            Name= name;
            Surname = surname;
            Id= id;
            Gender= gender;
            Birthday= birthday;
        }

        public string Name {
            get { 
                if (Gender == 'M')
                {
                    return "Mr. " + name;
                }
                else
                {
                    return "Mrs. " + name;
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be null");
                }
            }
        }
        public string Surname { 
            get
            { 
                return surname;
            }
            set {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    surname = value;
                }
                else
                {
                    Console.WriteLine("Surname cannot be null");
                }
            }
        }
        public string Id { get { return id; }
            set { 
                if(value.Length != 11)
                {
                    Console.WriteLine("Invalid id");
                }
                else
                {
                    id= value;
                }
            } 
        }
        public char Gender { get
            {
                return gender;
            }
            set
            {
                if(!char.IsWhiteSpace(value))
                {               
                    if(char.ToUpper(value) == 'M' || char.ToUpper(value) == 'F')
                    {
                        gender= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid gender");
                    }
                }
                else
                {
                    Console.WriteLine("Gender cannot be empty");
                }
            }
        }
        public DateTime Birthday 
        { get
            { return birthday; }
            set { 
                if (value < new DateTime(1900, 1, 1) && value > DateTime.Now)
                {
                    Console.WriteLine("Invalid date");
                }
                else
                {
                    birthday= value;
                }
            }      
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}"; 
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthday.Year;
        }
    }
}

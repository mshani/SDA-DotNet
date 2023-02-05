using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA
{
    public class User
    {
        public User(){ }

        public User(string u, string p)
        {
            Username = u;
            Password = p;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        
    }
}

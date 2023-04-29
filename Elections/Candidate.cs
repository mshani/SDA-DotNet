using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    internal class Candidate
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Votes { get; private set; } = 0;
        public void Vote()
        {
            Votes++;    
        }
    }
}

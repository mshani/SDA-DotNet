using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    internal class PoliticalParty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Votes { get; private set; } = 0;
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public void Vote()
        {
            Votes++;
        }
    }
}

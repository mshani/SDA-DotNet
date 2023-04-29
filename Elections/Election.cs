using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    internal class Election
    {
        public List<Candidate> ElectionCandidates { get; set; } = new List<Candidate>();
        public List<PoliticalParty> ElectionParties { get; set; } = new List<PoliticalParty>();
        public void VoteCanditate(int id){
            foreach (var c in ElectionCandidates)
            {
                if (c.Id == id)
                {
                    c.Vote();
                    break;
                }
            }
        }
        public void VoteParty(int id){
            foreach (var p in ElectionParties)
            {
                if (p.Id == id)
                {
                    p.Vote();
                    break;
                }
            }
        }

        public void PrintResultCandidate(int id)
        {

            foreach (var c in ElectionCandidates)
            {
                if(c.Id == id) { 
                    Console.Write($"{c.Id}: {c.Fullname} votes:{c.Votes}");
                }
                Console.WriteLine();
            }
        }
        public void PrintResultCandidates() {

            foreach (var c in ElectionCandidates)
            {
                Console.Write($"{c.Id}: {c.Fullname} votes: {c.Votes}");
                Console.WriteLine();
            }
        }
        public void PrintResultParties() {

            foreach (var p in ElectionParties)
            {
                Console.Write($"{p.Id}: {p.Name} votes: {p.Votes}");
                Console.WriteLine();
                foreach(var c in p.Candidates)
                {
                    Console.Write($"{p.Name}: {c.Id}: {c.Fullname} votes: {c.Votes}");
                    Console.WriteLine();
                }
            }
        }
    }
}

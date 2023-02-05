using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    internal class Novela: Libri
    {
        public virtual int NrNovelash { get; set; } 
        public List<string> Tituj { get; set; } = new List<string>();
    }
}

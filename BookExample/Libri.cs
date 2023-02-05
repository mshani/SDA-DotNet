using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    internal abstract class Libri
    {
        protected int NrFaqesh { get; set; }
        protected string Autori { get; set; }

        private string titulli = "";
        internal string GetTitull()
        {
            return titulli;
        }
        internal void SetTitull(string titull)
        {
             titulli = titull;
        }
    }
}

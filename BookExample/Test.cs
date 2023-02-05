using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    internal class Test
    {
        public void Execute()
        {
            Roman libri = new Roman();
            libri.SetTitull("Shpella e Pirateve");
            Console.WriteLine(libri.GetTitull());
            Novela novela = new Novela();
            novela.SetTitull("Gruaja me flatra");
            Console.WriteLine(novela.GetTitull());
            List<Libri> list = new List<Libri>();
            list.Add(libri);
            list.Add(novela);

        }
    }
}

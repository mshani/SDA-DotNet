using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    public class Item
    {
        public string company = "";
        protected int ProductionYear { get; set; }

        public Item (string company)
        {
            this.company = company;
        }
        public virtual void Company()
        {
            Console.WriteLine("Company: "+ company);
        }
    }
}

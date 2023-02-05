using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced
{
    internal class Fan : Item
    {
        string name = "";
        public new int ProductionYear { get; set; }
        public Fan(string name, string company) 
            : base(company)
        {
            base.ProductionYear = 2022;
            this.name = name;
        }
        public override void Company()
        {
            base.Company();
            this.Model();
        }
        public void Model()
        {
            Console.WriteLine("Model: "+ name);
        }
    }
}

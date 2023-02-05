namespace SDA
{
    internal class Rreth
    {
        double rreze;
        public double Rreze { 
            get 
            { 
                return rreze; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid argument");
                }
                else
                {
                    rreze = value;
                }
            }
        }
       
        public static readonly double Pi = 3.14;

        public Rreth()
        {
        }

        public Rreth(double Rreze)
        {
            rreze = Rreze;
        }

        public double Siperfaqja()
        {
            return this.Rreze * this.Rreze * Pi;
        }

        public double Perimetri()
        {
            return 2 * this.Rreze * Pi;
        }
    }
}

//Rreth rrethi = new Rreth();
//rrethi.Rreze = 5;
//Console.WriteLine(rrethi.Siperfaqja());
//Console.WriteLine(rrethi.Perimetri());
//Console.WriteLine(rrethi.Rreze);
//Console.WriteLine(Rreth.Pi);
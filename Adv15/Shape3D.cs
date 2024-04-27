namespace Adv15
{
    internal abstract class Shape3D : Shape, IFillable
    {
        public abstract double CalculateVolume();
        public void Fill(double v)
        {
            var volume = CalculateVolume();
            if (volume > v)
            {
                Console.WriteLine("Not pouring enough water");
            }
            else if (volume == v)
            {
                Console.WriteLine("Fill the figure with water to the brim");
            }
            else
            {
                Console.WriteLine("Will pour too much water into the figure and overflow");
            }
        }
    }
}

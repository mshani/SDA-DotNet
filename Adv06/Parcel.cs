using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv06
{
    internal class Parcel : IValidator
    {
        public int xLength { get; set; }
        public int yLength { get; set; }
        public int zLength { get; set; } 
        public float Weight { get; set; }
        public bool IsExpress { get; set; }

        public bool Validate()
        {
            if (xLength + yLength + zLength > 300)
            {
                Console.WriteLine("Total sum is greater than 300");
                return false;
            }
            if (xLength < 30 || yLength < 30 || zLength < 30)
            {
                Console.WriteLine("One of the dimentions is less than 30");
                return false;
            }
            if (IsExpress && Weight > 15)
            {
                Console.WriteLine("The parcel is too heavy for express");
                return false;
            }
            if (!IsExpress && Weight > 30)
            {
                Console.WriteLine("The parcel is too heavy");
                return false;
            }
            return true;
        }
    }
}

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
                return false;
            }
            if (xLength < 30 && yLength < 30 && zLength < 30)
            {
                return false;
            }
            if (IsExpress && Weight > 15)
            {
                return false;
            }
            if (!IsExpress && Weight > 30)
            {
                return false;
            }
            return true;
        }
    }
}

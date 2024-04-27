using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Adv21
{
    internal static class Extender
    {
        public static List<T> GetEveryNthElement<T>(List<T> list, int index, int skip)
        {
            //[a, b, c, d, e, f, g]
            //index = 2 and skip = 5
            List<T> result = new List<T>();
            int current = 0;
            foreach (T item in list)
            {
                if(current == index || current > index + skip)
                {
                    result.Add(item);
                }
                current++;
            }
            return result;
        }
    }
}

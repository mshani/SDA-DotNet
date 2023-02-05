using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Exchanger<T>
    {
        public void Swap (ref T item1, ref T item2) {
            T temp = item2;
            item2 = item1;
            item1 = temp;
        }
        public T GetDefault()
        {
            return default(T);
        }
    }
}

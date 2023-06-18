using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv19
{
    internal class BasketFullException : Exception
    {
        public BasketFullException()
        {
        }

        public BasketFullException(string message)
            : base(message)
        {
        }

        public BasketFullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

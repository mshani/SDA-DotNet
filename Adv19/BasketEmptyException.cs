using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv19
{
    internal class BasketEmptyException : Exception
    {
        public BasketEmptyException()
        {
        }

        public BasketEmptyException(string message)
            : base(message)
        {
        }

        public BasketEmptyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv19
{
    internal class Basket
    {
        private int state;
        public void AddToBasket()
        {
            if(state < 10)
            {
                state++;
            }
            else
            {
                throw new BasketFullException();
            }
        }
        public void RemoveFromBasket()
        {
            if (state > 1)
            {
                state--;
            }
            else
            {
                throw new BasketEmptyException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.GiftRegister
{
    internal class Gift
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Person GiftGiver { get; set; }

        public void RegisterGiftGiver(Person giftGiver)
        {
            if(giftGiver == null)
            {
                Console.Error.WriteLine("Gift giver cannot be null");
            }
            else
            {
                if (GiftGiver == null)
                {
                    GiftGiver = giftGiver;
                }
                else
                {
                    Console.Error.WriteLine("There is already a gift giver");
                }
            }
        }
        public void ReplaceGiftGiver(Person giftGiver)
        {
            if (giftGiver == null)
            {
                Console.Error.WriteLine("Gift giver cannot be null");
            }
            else
            {
                GiftGiver = giftGiver;
            }
        }
        public void RemoveGiftGiver()
        {            
              GiftGiver = null;
        }
    }
}

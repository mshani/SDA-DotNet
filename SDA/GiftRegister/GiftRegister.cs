using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA.GiftRegister
{
    internal class GiftRegister
    {
        public GiftRegister()
        {
            Gifts = new List<Gift>();
        }
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public List<Gift> Gifts { get; set; }

        public void RegisterGift(Gift gift)
        {
            bool exists = false;
            foreach (Gift g in Gifts)
            {
                if(g.Id == gift.Id) {
                    exists = true;
                    break;
                }
            }
            if(!exists)
            {
                Gifts.Add(gift);
            }
        }

        public void RemoveGift(Gift gift)
        {
            bool exists = false;
            foreach (Gift g in Gifts)
            {
                if (g.Id == gift.Id)
                {
                    exists = true;
                    break;
                }
            }
            if (exists && gift.GiftGiver == null)
            {
                Gifts.Remove(gift);
            }
        }

        public void DisplayAllGifts()
        {
            foreach (Gift g in Gifts)
            {
                Console.Write($"{g.Description} {g.Price}");
                if(g.GiftGiver != null)
                {
                    Console.Write($" from {g.GiftGiver.Name} {g.GiftGiver.Surname}");
                }
                Console.WriteLine();
            }
        }

        public void DisplayAvailableGifts()
        {
            foreach (Gift g in Gifts)
            {
                if(g.GiftGiver == null)
                {
                    Console.WriteLine($"{g.Description}  {g.Price}");
                }
            }
        }
    }
}

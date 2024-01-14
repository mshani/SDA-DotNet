using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv18
{
    internal class Zoo
    {
        public List<string> Animals { get; set; } = new List<string>();

        public int GetNumberOfAllAnimals()
        {
            return Animals.Count;
        }
        public Dictionary<string, int> GetAnimalsCount()
        {
            var result = new Dictionary<string, int>();
            foreach (var animal in Animals)
            {
                if (result.ContainsKey(animal)){
                    result[animal]++;
                }
                else{
                    result.Add(animal, 1);
                }
            }
            return result;
        }
        public Dictionary<string, int> GetAnimalsCountSorted()
        {
            var dict = GetAnimalsCount();
            var result = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            return result;
        }

        public void AddAnimals(string animal, int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Animals.Add(animal);
                }
            }
        }
    }
}

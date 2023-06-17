using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv05
{
    internal class WeaponMagazine
    {
        private Stack<string> magazine = new Stack<string>();
        private readonly int maxCapacity;
        public WeaponMagazine(int capacity){
            this.maxCapacity = capacity;
        }
        public void LoadBullet(string bullet){
            if(magazine.Count < maxCapacity){
                magazine.Push(bullet);
            }
            else{
                Console.WriteLine($"Full magazine. Cannot add: {bullet}.");
            }
        }
        public bool IsLoaded(){
            var isLoaded = magazine.Count > 0 ? true : false;
            return isLoaded;
        }

        public void Shoot(){
            if (magazine.Count > 0){
                var bullet = magazine.Pop();
                Console.WriteLine(bullet);
            }
            else{
                Console.WriteLine("Empty magazine");
            }
        }
    }
}

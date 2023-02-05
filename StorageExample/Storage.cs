using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StorageExample
{
    internal class Storage
    {
        private Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        public void AddStorage(string key, string value)
        {
            if(!map.ContainsKey(key)){
                var list = new List<string>();  
                list.Add(value);
                map.Add(key, list);
            }
            else {
                var list = map[key];
                if (!list.Contains(value))
                {
                    list.Add(value);
                    map[key] = list;
                }
                else
                {
                    Console.WriteLine($"Key: {key}, value: {value} exist!");
                }
            }
        }
        public void PrintValues(string key) { 
            var elements = map[key];
            if(elements != null){
                foreach (var element in elements)
                {
                    Console.WriteLine($"Key: {key}, value: {element}");
                }
            }
        }

        public List<string> FindKeys(string value) {
            var keyList = new List<string>();
            foreach(var element in map) {
                if (element.Value.Contains(value))
                {
                    keyList.Add(element.Key);
                }
            }
            return keyList;
        }
    }
}

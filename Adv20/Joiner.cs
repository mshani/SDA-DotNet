﻿using System.Text;

namespace Adv20
{
    internal class Joiner
    {  
        string separator;
        public Joiner(string separator)
        {
            this.separator = separator;
        }
        public string Join<T>(List<T> list)
        {
            var result = new StringBuilder();
            int counter = 1;
            foreach (var item in list)
            {
                result.Append(item.ToString());
                if (counter != list.Count)
                {
                    result.Append(separator);
                }
                counter++;
            }
            return result.ToString();
        }
    }
}

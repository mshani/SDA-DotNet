using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExercises
{
    internal class Exercises
    {
        public void E01()
        {
            Console.WriteLine("Enter words separated by coma");

            string value = Console.ReadLine();
            List<string> values = value.Split(',').ToList();
            List<string> cleanedList = Sanitize(values);
            List<string> sortedList = OrderDesc(cleanedList);

            foreach (string element in sortedList)
            {
                Console.Write(element + ",");
            }
            List<string> Sanitize(List<string> words)
            {
                List<string> list = new List<string>();
                foreach (string word in words)
                {
                    string newWord = word.Trim();
                    list.Add(newWord);
                }
                return list;
            }

            List<string> OrderDesc(List<string> words)
            {
                List<string> result =
                    words
                    .OrderByDescending(x => x)
                    .ToList();
                return result;
            }
        }
    }
}

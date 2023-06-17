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
        public void Task01()
        {
            string[] arr = { "test", "Abc", "whatever", "done", "hi", "yes", "bye", "Bye" };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                print<string>(arr);
            }


            void print<T>(T[] elements)
            {
                foreach (var n in elements)
                {
                    Console.Write(n + ", ");
                }
                Console.WriteLine();
            }
        }
        public void Task03()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.TryAdd("Java", 18);
            dictionary.TryAdd("Python", 4);
            dictionary.TryAdd("C#", 12);
            dictionary.TryAdd("Js", 5);
            dictionary.TryAdd("Php", 3);
            Print(dictionary);

            void Print(Dictionary<string, int> dictionary)
            {
                foreach (var element in dictionary)
                {
                    if (!element.Equals(dictionary.Last()))
                    {
                        Console.WriteLine($"Key: {element.Key}, Value: {element.Value},");
                    }
                    else
                    {
                        Console.WriteLine($"Key: {element.Key}, Value: {element.Value}.");
                    }
                }
            }
        }


    }
}

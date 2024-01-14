using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv23
{
    internal static class WordProcessor
    {
        public static Dictionary<string, int> CountWords(string content)
        {
            string[] words = content.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }

        public static string CreateTable(Dictionary<string, int> wordCount)
        {
            const int columnWidth = 15;
            string header = $"{"Word",-columnWidth}{"Count",-columnWidth}\n";
            string separator = new string('-', columnWidth * 2 + 1) + "\n";
            string table = header + separator;

            foreach (var pair in wordCount.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                table += $"{pair.Key,-columnWidth}{pair.Value,-columnWidth}\n";
            }

            return table;
        }
    }
}

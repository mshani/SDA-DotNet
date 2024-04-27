Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.TryAdd("Java", 18);
dictionary.TryAdd("Python", 4);
dictionary.TryAdd("C#", 12);
dictionary.TryAdd("Js", 5);
dictionary.TryAdd("Php", 3);

PrintDictionary(dictionary);

void PrintDictionary(Dictionary<string, int> dictionary)
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
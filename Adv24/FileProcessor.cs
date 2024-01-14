using Newtonsoft.Json;

namespace Adv24
{
    internal static class FileProcessor
    {
        public static T LoadFromFile<T>(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<T>(json);
            }

            throw new FileNotFoundException($"File not found: {fileName}");
        }
        public static void SaveToFile<T>(string fileName, T data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(fileName, json);
            Console.WriteLine($"Data saved to {fileName}");
        }
    }
}

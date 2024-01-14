using Adv23;

Console.WriteLine("Enter the input file name (including extension):");
string inputFileName = Console.ReadLine();
try
{

    string inputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, inputFileName);
    string content = File.ReadAllText(inputFilePath);

    Dictionary<string, int> wordCount = WordProcessor.CountWords(content);
    string table = WordProcessor.CreateTable(wordCount);

    string outputFileName = "WordCountResults.txt";
    string outputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outputFileName);

    File.WriteAllText(outputFilePath, table);

    Console.WriteLine($"Word count results have been saved to '{outputFileName}'.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
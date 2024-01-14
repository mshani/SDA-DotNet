Console.WriteLine("Enter the file name including extension:");
string fileName = Console.ReadLine();

try
{
    // Extract file name without extension
    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);

    // Read the content of the file
    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
    string content = File.ReadAllText(filePath);

    // Reverse the content
    char[] contentArray = content.ToCharArray();
    Array.Reverse(contentArray);
    string reversedContent = new string(contentArray);

    // Reverse the file name without extension
    char[] fileNameArray = fileNameWithoutExtension.ToCharArray();
    Array.Reverse(fileNameArray);
    string reversedFileName = new string(fileNameArray);

    // Add back the extension to the reversed file name
    string reversedFileNameWithExtension = reversedFileName + Path.GetExtension(fileName);

    // Create a new file with reversed content and title
    string newFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, reversedFileNameWithExtension);
    File.WriteAllText(newFilePath, reversedContent);

    Console.WriteLine($"File '{fileName}' has been reversed and saved as '{reversedFileNameWithExtension}'.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
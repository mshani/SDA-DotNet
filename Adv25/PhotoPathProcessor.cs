namespace Adv25
{
    internal static class PhotoPathProcessor
    {
        public static void DisplayPhotos(string directoryPath)
        {
            try
            {
                Console.WriteLine($"Photos in directory: {directoryPath}");

                string[] photoFiles = Directory
                    .GetFiles(directoryPath, "*.png", SearchOption.AllDirectories)
                    .Union(Directory.GetFiles(directoryPath, "*.jpg", SearchOption.AllDirectories))
                    .ToArray();

                foreach (string filePath in photoFiles)
                {
                    Console.WriteLine(filePath);
                }

                Console.WriteLine($"Total photos found: {photoFiles.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

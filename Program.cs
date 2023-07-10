using System.IO.Compression;

namespace Quiz
{
}  internal class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\tdarr\OneDrive\Desktop\Test"; // Replace with the path to the source directory containing the zip files
            string destinationDirectory = @"C:\Users\tdarr\OneDrive\Desktop\Test 2"; // Replace with the path to the destination directory

            try
            {
                string[] zipFiles = Directory.GetFiles(sourceDirectory, "*.zip"); // Get all zip files in the source directory

                foreach (string zipFile in zipFiles)
                {
                    string fileName = Path.GetFileName(zipFile);
                    string destinationPath = Path.Combine(destinationDirectory, fileName);

                    File.Move(zipFile, destinationPath); // Move the zip file to the destination directory

                    ZipFile.ExtractToDirectory(destinationPath, destinationDirectory); // Extract the zip file to the destination directory

                    Console.WriteLine($"Successfully moved and extracted {fileName}");
                }

                Console.WriteLine("All files moved and extracted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while moving and extracting files: " + ex.Message);



            }










        }
    }
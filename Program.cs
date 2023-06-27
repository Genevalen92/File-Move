using System.IO;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\tdarr\OneDrive\Desktop\Test"; // Replace with your source folder path
        string destinationPath = @"C:\Users\tdarr\OneDrive\Desktop\Test 2"; // Replace with your destination folder path

        string fileName = "Original.txt"; // Replace with the name of the file you want to move

        string sourceFile = Path.Combine(sourcePath, fileName);
        string destinationFile = Path.Combine(destinationPath, fileName);

        // Check if the source file exists
        if (File.Exists(sourceFile))
        {
            // Check if the destination file already exists
            if (File.Exists(destinationFile))
            {
                Console.WriteLine("The file {0} already exists in the destination folder.", fileName);
            }
            else
            {
                // Move the file to the destination folder
                File.Move(sourceFile, destinationFile);
                Console.WriteLine("The file {0} has been moved to the destination folder.", fileName);
                Console.Beep();
            }
        }
        else
        {
            Console.WriteLine("The file {0} does not exist in the source folder.", fileName);
        }

        Console.ReadLine();
    }
}

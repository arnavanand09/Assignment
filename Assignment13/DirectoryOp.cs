using System;
using System.IO;


namespace Assignment13
{
    internal class DirectoryOp
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\.Net FullStack\sample";

            string demo1 = Path.Combine(filePath, "demo1");
            string demo2 = Path.Combine(filePath, "demo2");

            try
            {
                
                Directory.CreateDirectory(demo1);
                Directory.CreateDirectory(demo2);
                Console.WriteLine("Directories created.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directories: {ex.Message}");
            }

            string file1 = Path.Combine(filePath, "file1.txt");       
            string file2 = Path.Combine(filePath, "file2.txt");

            try
            {
                File.WriteAllText(file1, "This is file1 written using File.");

                FileInfo fi = new FileInfo(file2);
                using (StreamWriter writer = fi.CreateText())
                {
                    writer.WriteLine("This is file2 written using FileInfo.");
                }

                Console.WriteLine("Files created and content written.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to files: {ex.Message}");
            }

            string copiedFilePath = Path.Combine(demo2, "file1_copy.txt");
            File.Copy(file1, copiedFilePath, true);
            Console.WriteLine("file1 copied to demo2.");

            Console.WriteLine("\n Contents inside folder ");
            string[] directories = Directory.GetDirectories(filePath);
            string[] files = Directory.GetFiles(filePath);

            Console.WriteLine("\nDirectories:");
            foreach (var dir in directories)
            {
                Console.WriteLine($"{dir} - Created: {Directory.GetCreationTime(dir)}");
            }

            Console.WriteLine("\nFiles:");
            foreach (var file in files)
            {
                Console.WriteLine($"{file} - Created: {File.GetCreationTime(file)}");
            }

            Console.WriteLine("\nContents of demo2 folder:");
            foreach (var file in Directory.GetFiles(demo2))
            {
                Console.WriteLine($"{file} - Created: {File.GetCreationTime(file)}");
            }

            foreach (var file in Directory.GetFiles(filePath))
            {
                File.Delete(file);
            }
            foreach (var file in Directory.GetFiles(demo2))
            {
                File.Delete(file);
            }
            Console.WriteLine("\nAll files deleted.");

            Directory.Delete(demo1, true);  
            Directory.Delete(demo2, true);
            Directory.Delete(filePath, false);  
            Console.WriteLine("All directories deleted.");
        }
    }
}

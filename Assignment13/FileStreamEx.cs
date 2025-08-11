using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment13
{
    internal class FileStreamEx
    {
        static void Main()
        {
            string filePath = "D:\\.Net FullStack\\sample"; 

            while (true)
            {
                Console.WriteLine("File Operations Menu ");
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Add contents to the file");
                Console.WriteLine("3. Append contents to the file");
                Console.WriteLine("4. Display contents one by one ");
                Console.WriteLine("5. Display all contents together");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        try
                        {
                            using (FileStream fs = new FileStream(filePath, FileMode.Create))
                            {
                                Console.WriteLine($"File '{filePath}' created successfully.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error creating file: {ex.Message}");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.Write("Enter content to write: ");
                            string content = Console.ReadLine();
                            using (FileStream fs = new FileStream(filePath, FileMode.Create))
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                writer.WriteLine(content);
                            }
                            Console.WriteLine("Content written successfully (overwritten).");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error writing to file: {ex.Message}");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.Write("Enter content to append: ");
                            string content = Console.ReadLine();
                            using (FileStream fs = new FileStream(filePath, FileMode.Append))
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                writer.WriteLine(content);
                            }
                            Console.WriteLine("Content appended successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error appending to file: {ex.Message}");
                        }
                        break;

                    case 4:
                        try
                        {
                            using (FileStream fs = new FileStream(filePath, FileMode.Open))
                            using (StreamReader reader = new StreamReader(fs))
                            {
                                Console.WriteLine("Contents (line by line):");
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("File not found. Please create the file first.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error reading file: {ex.Message}");
                        }
                        break;

                    case 5:
                        try
                        {
                            using (FileStream fs = new FileStream(filePath, FileMode.Open))
                            using (StreamReader reader = new StreamReader(fs))
                            {
                                string content = reader.ReadToEnd();
                                Console.WriteLine("Full file content:");
                                Console.WriteLine(content);
                            }
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("File not found. Please create the file first.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error reading file: {ex.Message}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }

}
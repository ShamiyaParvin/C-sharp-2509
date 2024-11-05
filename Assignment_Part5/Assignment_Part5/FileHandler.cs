using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part5
{
    public class FileHandler
    {
        public void ReadFile(string filePath)
        {
            string fileContent = "";
            try
            {
                // read the entire file content as a string
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // Handle any other unexpected errors
            }
            finally
            {
                Console.WriteLine("In Finally block :- File reading operation completed");
            }
        }
    }
}

using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\yelik\\iCloudDrive\\Desktop\\Automation scripts\\Sample CSV\\state_us.csv";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        // Read the CSV file
        using (TextFieldParser parser = new TextFieldParser(filePath))
        {
            // Set the delimiter for the CSV file (comma by default)
            parser.Delimiters = new string[] { "," };

            // Handle fields enclosed in double quotes
            parser.HasFieldsEnclosedInQuotes = true;

            // Read and process each row in the CSV file
            while (!parser.EndOfData)
            {
                // Read current row fields
                string[] fields = parser.ReadFields();

                // Process each field in the row
                foreach (string field in fields)
                {
                    Console.Write(field + "\t");
                }

                Console.WriteLine(); // Move to the next line for the next row
            }
        }
    }
}

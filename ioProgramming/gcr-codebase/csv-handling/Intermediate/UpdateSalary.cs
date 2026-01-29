using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "updated_employees.csv";

        string[] lines = File.ReadAllLines(inputFile);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[2] == "IT")
            {
                double salary = double.Parse(data[3]);
                salary += salary * 0.10;

                data[3] = salary.ToString();
                lines[i] = string.Join(",", data);
            }
        }

        File.WriteAllLines(outputFile, lines);

        Console.WriteLine("Updated salary file created!");
    }
}

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "students.csv";

        string[] lines = File.ReadAllLines(path);

        Console.WriteLine("Student Records:\n");

        for (int i = 1; i < lines.Length; i++) // Skip header
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine($"ID: {data[0]}");
            Console.WriteLine($"Name: {data[1]}");
            Console.WriteLine($"Age: {data[2]}");
            Console.WriteLine($"Marks: {data[3]}");
            Console.WriteLine("----------------------");
        }
    }
}

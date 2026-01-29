using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "students.csv";
        string[] lines = File.ReadAllLines(path);

        Console.WriteLine("Students with Marks > 80:\n");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine($"{data[1]} scored {marks}");
            }
        }
    }
}

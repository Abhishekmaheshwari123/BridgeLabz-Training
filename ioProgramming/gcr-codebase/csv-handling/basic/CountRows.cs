using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "students.csv";

        string[] lines = File.ReadAllLines(path);

        int recordCount = lines.Length - 1; // excluding header

        Console.WriteLine("Total Records = " + recordCount);
    }
}

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string path = "students.csv";

        HashSet<string> ids = new HashSet<string>();
        List<string> duplicates = new List<string>();

        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string id = lines[i].Split(',')[0];

            if (!ids.Add(id))
                duplicates.Add(lines[i]);
        }

        Console.WriteLine("Duplicate Records:\n");

        foreach (var dup in duplicates)
            Console.WriteLine(dup);
    }
}

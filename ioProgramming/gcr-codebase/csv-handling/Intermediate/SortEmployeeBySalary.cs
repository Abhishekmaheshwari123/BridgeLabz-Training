using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = "employees.csv";
        string[] lines = File.ReadAllLines(path);

        var sorted = lines.Skip(1)
                          .Select(line => line.Split(','))
                          .OrderByDescending(emp => int.Parse(emp[3]))
                          .Take(5);

        Console.WriteLine("Top 5 Highest Paid Employees:\n");

        foreach (var emp in sorted)
        {
            Console.WriteLine($"{emp[1]} - Salary: {emp[3]}");
        }
    }
}

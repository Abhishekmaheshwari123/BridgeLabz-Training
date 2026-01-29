using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var file1 = File.ReadAllLines("students1.csv").Skip(1);
        var file2 = File.ReadAllLines("students2.csv").Skip(1);

        var dict2 = file2.ToDictionary(
            line => line.Split(',')[0],
            line => line.Split(',').Skip(1).ToArray()
        );

        using StreamWriter sw = new StreamWriter("merged.csv");
        sw.WriteLine("ID,Name,Age,Marks,Grade");

        foreach (var line in file1)
        {
            var data1 = line.Split(',');
            string id = data1[0];

            if (dict2.ContainsKey(id))
            {
                var data2 = dict2[id];
                sw.WriteLine($"{id},{data1[1]},{data1[2]},{data2[0]},{data2[1]}");
            }
        }

        Console.WriteLine("Merged CSV created!");
    }
}

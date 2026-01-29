using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "largefile.csv";

        using StreamReader reader = new StreamReader(path);

        string line;
        int count = 0;

        while (!reader.EndOfStream)
        {
            for (int i = 0; i < 100 && (line = reader.ReadLine()) != null; i++)
            {
                count++;
            }

            Console.WriteLine($"Processed Records: {count}");
        }
    }
}

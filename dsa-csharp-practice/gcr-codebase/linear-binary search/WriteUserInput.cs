using System.IO;
using System;

class WriteUserInput
{
    public static void Run(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            string input = Console.ReadLine();
            sw.Write(input);
        }
    }
}

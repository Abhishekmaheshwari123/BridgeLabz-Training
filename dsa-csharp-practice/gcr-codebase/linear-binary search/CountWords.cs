using System;
using System.IO;
using System.Linq;

class CountWord
{
    static void Main()
    {
        string word = Console.ReadLine();
        int count = 0;
        using (StreamReader sr = new StreamReader("data.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                count += line.Split(' ').Count(w => w == word);
        }
        Console.WriteLine(count);
    }
}

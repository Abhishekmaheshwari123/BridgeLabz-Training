using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        HashSet<char> set = new HashSet<char>();
        foreach (char c in s)
            if (!set.Contains(c))
            {
                sb.Append(c);
                set.Add(c);
            }
        Console.WriteLine(sb.ToString());
    }
}

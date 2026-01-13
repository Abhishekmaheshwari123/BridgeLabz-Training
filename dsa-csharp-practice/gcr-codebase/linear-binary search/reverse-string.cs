using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char c = sb[i];
            sb[i] = sb[j];
            sb[j] = c;
        }
        Console.WriteLine(sb.ToString());
    }
}

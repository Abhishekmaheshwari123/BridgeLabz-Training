using System;
class CountSubstring
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        String t = Console.ReadLine();
        int c = 0;
        int i = 0;
        while(true)
        {
            int index = s.IndexOf(t,i);
            if(index == -1) break;
            c++;
            i = index + 1;
        }

        Console.WriteLine(c);
    }
}
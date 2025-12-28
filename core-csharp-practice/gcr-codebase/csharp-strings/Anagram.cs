using System;
class Anagram
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        String t = Console.ReadLine();


        if(s.Length != t.Length)
        {
            Console.WriteLine("Not Anagram");
            return ;
        }
        s = s.Replace(" ","").ToLower();
        t = s.Replace(" ","").ToLower();

        int[]freq = new int[256];

        foreach (char a in s)
        {
            freq[a]++;
        }
        foreach(char a in t)
        {
            freq[a]--;
            if(freq[a] < 0)
            {
                Console.WriteLine("Not Anagram");
                return ;
            }
        }
        Console.WriteLine("Anagram");
    }
}
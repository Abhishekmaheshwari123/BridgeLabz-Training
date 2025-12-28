using System;
class RemoveDuplicates
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        String ans = "";
        int[]freq = new int[256];
        for(int i = 0; i < s.Length; i++)
        {
            if(freq[s[i] - '0'] == 0) ans+=s[i];
            freq[s[i] - '0']++;
        }

        Console.WriteLine(ans);
    }
}
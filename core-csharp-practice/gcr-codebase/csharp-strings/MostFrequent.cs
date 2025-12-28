using System;
class MostFrequent
{
    public static void Main(String[]args)
    {
        String s = Console.ReadLine();
        int maxi = 0;
        char a = s[0];
        int[]freq = new int[256];
        for(int i = 0; i < s.Length; i++)
        {
            freq[s[i] - '0']++;
            if(freq[s[i] - '0'] > maxi)
            {
                maxi = freq[s[i] - '0'];
                a = s[i];
            }
        }

        Console.WriteLine("Most Frequent Character : "+a);
    }
}
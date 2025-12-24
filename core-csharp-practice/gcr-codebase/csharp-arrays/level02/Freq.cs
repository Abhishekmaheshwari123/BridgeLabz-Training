using System;
class Freq
{
    public static void Main(string[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int[]freq = new int[10];
        while(n > 0)
        {
            freq[n%10]++;
            n /= 10;
        }

        int maxi = 0;
        int ans = 0;
        for(int i = 0; i < 10; i++)
        {
            if(maxi <= freq[i])
            {
                maxi = freq[i];
                ans = i;
            }
        }
        Console.WriteLine("Maxi Occuring digit is "+ ans);
    }
}
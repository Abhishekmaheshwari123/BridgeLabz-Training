using System;
class LongestWord
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        string[] arr = s.Split(' ');

        int maxi = 0;
        String ans = "";
        for(int i = 0; i < arr.Length; i++)
        {
            if(maxi < arr[i].Length)
            {
                maxi = arr[i].Length;
                ans = arr[i];
            }
        }

        Console.WriteLine(ans);
    }
}
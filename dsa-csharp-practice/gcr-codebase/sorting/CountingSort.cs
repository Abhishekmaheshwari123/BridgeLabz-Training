using System;
class CountingSort
{
    public static void Main(string[]args)
    {
        int[]arr = {6,5,3,6,7,5,2,11,45,6};
        int maxi = 0;
        int c = 0;
        foreach (int i in arr) maxi = Math.Max(maxi , i);

        int[]freq = new int[maxi+1];
        foreach (int i in arr) freq[i]++;
        // int j = 0;
        for(int i = 0; i < maxi+1; i++)
        {
            for (int j = 0; j < freq[i]; j++)
            {
                arr[c++] = i;
            }
        }

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
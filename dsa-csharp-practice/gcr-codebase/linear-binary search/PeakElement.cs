using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            int m = (l + r) / 2;
            if (arr[m] < arr[m + 1])
                l = m + 1;
            else
                r = m;
        }
        Console.WriteLine(arr[l]);
    }
}

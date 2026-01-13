using System;

class RotationPoint
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int l = 0, r = arr.Length - 1;
        while (l < r)
        {
            int m = (l + r) / 2;
            if (arr[m] > arr[r])
                l = m + 1;
            else
                r = m;
        }
        Console.WriteLine(l);
    }
}

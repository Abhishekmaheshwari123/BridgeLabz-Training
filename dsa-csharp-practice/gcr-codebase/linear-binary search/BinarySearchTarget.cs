using System;

class BinarySearchTarget
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int t = int.Parse(Console.ReadLine());
        int l = 0, r = arr.Length - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (arr[m] == t)
            {
                Console.WriteLine(m);
                return;
            }
            if (arr[m] < t)
                l = m + 1;
            else
                r = m - 1;
        }
        Console.WriteLine(-1);
    }
}

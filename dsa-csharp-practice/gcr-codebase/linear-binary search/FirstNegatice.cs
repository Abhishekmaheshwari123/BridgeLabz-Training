using System;

class FirstNegative
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());
        foreach (int x in arr)
            if (x < 0)
            {
                Console.WriteLine(x);
                return;
            }
        Console.WriteLine(0);
    }
}

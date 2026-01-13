using System;
using System.Collections.Generic;

class FirstMissingPositive
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        HashSet<int> set = new HashSet<int>(arr);
        int i = 1;
        while (true)
        {
            if (!set.Contains(i))
            {
                Console.WriteLine(i);
                return;
            }
            i++;
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
class Reverse
{
    public static void Main(String[] args)
    {
        int ele = int.Parse(Console.ReadLine());
        int size = (int)Math.Log10(ele) + 1;
        int[]arr = new int[size];
        for(int i = 0; i < size; i++)
        {
            arr[i] = ele % 10;
            ele /= 10;
        }

        int reversed = 0;;
        for(int i = 0; i < size; i++)
        {
            reversed = reversed * 10 + arr[i];
        }

        Console.WriteLine(reversed);
    }
}
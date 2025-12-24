using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
class Largest2
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
        Array.Reverse(arr);
        int largest = 0;
        int secondLargest = 0;
        for(int i = 0; i < size; i++)
        {
            if(arr[i] == i)break;
            if(largest < arr[i])
            {
                if(largest > secondLargest)   secondLargest = largest;
                largest = arr[i];
            }
            else if(secondLargest < arr[i] && arr[i] < largest) secondLargest = arr[i];
        }

        Console.WriteLine(largest +" "+ secondLargest);


    }
}
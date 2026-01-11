using System;
class BubbleSort
{
    public static void Main(string[]args)
    {
        int []arr = {6,5,3,6,7,5,2,11,45,6};

        Bubblesort(arr);

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    static void Bubblesort(int[]arr)
    {
        int n = arr.Length;
        for(int i = 0; i < n; i++)
        {
            bool swapped = false;
            for(int j = 0; j < n - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                    swapped = true;
                }
            }
            if(!swapped)break;
        }
    }
}
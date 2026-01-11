using System;
class InsertionSort
{
    public static void Main(String[]args)
    {
        int[]arr = {6,5,3,6,7,5,2,11,45,6};

        Insertionsort(arr);

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    static void Insertionsort(int[]arr)
    {
        int n = arr.Length;

        for(int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while(j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}
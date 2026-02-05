using System;

class QuickSort
{
    public static void Main(string[] args)
    {
        int[] arr = { 6, 5, 3, 6, 7, 5, 2, 11, 45, 6 };
        Quicksort(arr, 0, arr.Length - 1);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Quicksort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);

            Quicksort(arr, low, p - 1);
            Quicksort(arr, p + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];  
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }        
        int t = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = t;

        return i + 1;
    }
}

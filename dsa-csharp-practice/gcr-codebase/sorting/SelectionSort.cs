using System;
class SelectionSort
{
    public static void Main(String[] args)
    {
        int[] arr = {3,5,4,3,2,3,7,8};

        Selectionsort(arr);
        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    static void Selectionsort(int[] arr)
    {
        int n = arr.Length;
        for(int i = 0; i < n; i++)
        {
            int miniIndex = -1;
            for (int j = i+1; j < n; j++)
            {
                if(arr[i] > arr[j] && (miniIndex == -1 || arr[j] < arr[miniIndex]))
                {
                    miniIndex = j;
                }                
            }
            if(miniIndex != -1)
            swap(i , miniIndex , arr);
        }
    }

    static void swap(int i, int j, int[] arr)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
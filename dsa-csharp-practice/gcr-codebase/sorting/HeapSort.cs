using System;
class HeapSort
{
    public static void Main(String[] args)
    {
        int[]arr = { 6,5,3,6,7,5,2,11,45,6 };

        heapsort(arr);

        foreach (int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    static void heapsort(int[] arr)
    {
        int n = arr.Length;
        for(int i = n/2 - 1; i >= 0; i--)
        {
            heapify(arr,i,n);
        }
        for(int i = n-1 ; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            heapify(arr,0,i);
        }
    }


    static void heapify(int[]arr, int i, int n)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2*i + 2;

        if(left < n && arr[left] > arr[largest])
        {
            largest = left;
        }
        if(right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if(largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;
            heapify(arr,largest , n);
        }


    }
}
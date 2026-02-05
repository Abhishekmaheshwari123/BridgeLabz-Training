using System;
class MergeSort
{
    public static void Main(string[]args)
    {
        int[]arr = {6,5,3,6,7,5,2,11,45,6};
        int n = arr.Length;
        Divide(0,n-1,arr);

        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }

    static void Divide(int start, int end, int[]arr)
    {
        if(start >= end) return ;
        int mid = (start + end) / 2;

        Divide(start , mid, arr);
        Divide(mid + 1, end, arr);
        Conqueror(start , mid, end, arr);
    }

    static void Conqueror(int start, int mid, int end, int[]arr)
    {
        int[] temp = new int[end - start + 1];
        int left = start;
        int right = mid + 1;
        int c = 0;
        while(left <= mid && right <= end)
        {
            if(arr[left] <= arr[right]) temp[c++] = arr[left++];
            else temp[c++] = arr[right++];
        }

        while(left <= mid) temp[c++] = arr[left++];
        while(right <= end) temp[c++] = arr[right++];
        for(int i = 0, j = start; i < temp.Length;j++, i++)
        {
            arr[j] = temp[i];
        }
    }
}
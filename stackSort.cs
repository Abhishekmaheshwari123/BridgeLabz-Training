using System;
using System.Collections.Generic;
class stackSort
{
    public static void Main(String[]args)
    {
        Pair[]arr = new Pair[10];
        for(int i = 0; i < 10; i++)
        {
            char a = Console.ReadLine()[0];
            arr[i] = new Pair(a , (int)(a - '!'));
        }

        mergeSort(0,arr.Length-1,arr);
        Stack<char> st = new Stack<char>();

        for(int i = 0; i < arr.Length; i++)
        {
            st.Push(arr[i].character);
        }

        while (st.Count > 0)
        {
            Console.Write(st.Pop()+"  ");
        }
        Console.WriteLine();
    }



    static void mergeSort(int l, int r, Pair[] arr)
    {
        if(l < r)
        {
            int  mid = (l + r) / 2;
            mergeSort(l , mid, arr);
            mergeSort(mid + 1, r, arr);


            merge(l , mid , r , arr);
        }
    }

    static void merge(int l, int mid, int r, Pair[]arr)
    {
        Pair[] temp = new Pair[r - l + 1];
        int left = l;
        int right = mid + 1;

        int c = 0;

        while(left <= mid && right <= r)
        {
            if(arr[left].value <= arr[right].value)
            {
                temp[c++] = arr[left++];
            }
            else
            {
                temp[c++] = arr[right++];
            }
        }

        while(left <= mid)
        {
            temp[c++] = arr[left++];
        }
        while(right <= r)
        {
            temp[c++] = arr[right++];
        }


        // copy

        for(int i = 0, j = l; i < temp.Length; i++,j++)
        {
            arr[j] = temp[i];
        }
    }
}

class Pair
{
    public char character;
    public int value;
    public Pair(char chara , int Value)
    {
        character = chara;
        value = Value;
    }
}
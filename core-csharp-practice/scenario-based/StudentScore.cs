using System;
using System.ComponentModel.DataAnnotations;
class StudentScore
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        int[]arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            int ele = int.Parse(Console.ReadLine());
            while(ele < 0)
            {
                ele = int.Parse(Console.ReadLine());                
            }
            arr[i] = ele;
        }

        int sum = 0;
        int maxi = 0;
        int mini = (int)1e9;
        foreach(int i in arr ) {
            sum += i;
            maxi = Math.Max(maxi , i);
            mini = Math.Min(mini , i);
        }

        double average = (double) sum / n;
        Console.WriteLine("Average : "+average +"   maximum "+maxi+"  minimum "+mini);

        foreach(int i in arr)
        {
            if(i >= (int)average)Console.Write(i+" ");
        }

    }
}
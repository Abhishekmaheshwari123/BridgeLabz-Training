using System;
class RandomN
{
    public static void Main(String[]args)
    {
        int[]arr = Generate4DigitRandomArray();  
        Console.Write("Random Number :  ")  ;
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();


        double[]ans = FindAverageMinMax(arr);
        Console.Write("Maximum is : "+ans[0]+"  Minimum is : "+ans[1]+"  Average is : "+ans[2])  ;


    }

    static double[] FindAverageMinMax(int[]arr)
    {
        double[]ans = new double[3];
        double sum = 0;
        double maxi = 0;
        double mini = (int)1e9;
        foreach(int i in arr)
        {
            sum += i;
            maxi = Math.Max(i , maxi);
            mini = Math.Min(i , mini);
        }
        ans[0] = maxi;
        ans[1] = mini;
        ans[2] = sum / 5;

        return ans;
    }
    static int[] Generate4DigitRandomArray()
    {
        int[]arr = new int[5];
        Random rand = new Random();
        for(int i = 0; i < 5; i++)
        {
            int random = rand.Next(1000,10000);
            arr[i] = random;
        }
        return arr;
    }
}
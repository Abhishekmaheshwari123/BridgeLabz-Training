using System;

class MeanYoungTall
{
    static void Main(string[] args)
    {
        int[] heights = GenerateHeights();
        foreach (int h in heights)
        {
            Console.Write(h + " ");
        }
        Console.WriteLine();

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        Console.WriteLine("Sum of heights : " + sum);
        Console.WriteLine("Mean height    : " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height : " + tallest);
    }
    static int[] GenerateHeights()
    {
        int[] heights = new int[11];
        Random rand = new Random();

        for(int i = 0; i < heights.Length; i++)
        {
            heights[i] = rand.Next(150, 251); // last ele. is excluded
        }

        return heights;
    }

    static int FindSum(int[] arr)
    {
        int sum = 0;
        foreach(int value in arr)
        {
            sum += value;
        }
        return sum;
    }
    static double FindMean(int[] arr)
    {
        return(double)FindSum(arr) / arr.Length;
    }
    static int FindShortest(int[] arr)
    {
        int min = arr[0];
        foreach(int value in arr)
        {
            if (value < min)
                min = value;
        }
        return min;
    }
    static int FindTallest(int[] arr)
    {
        int max = arr[0];
        foreach(int value in arr)
        {
            if (value > max)
                max = value;
        }
        return max;
    }
}

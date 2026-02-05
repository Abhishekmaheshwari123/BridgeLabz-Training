using System;

class FitnessTracker
{
    static void Main()
    {
        int[] steps = { 8200, 15000, 10200, 9800, 12000, 9000 };

        Console.WriteLine("Before Ranking:");
        PrintSteps(steps);

        BubbleSortOptimized(steps);

        Console.WriteLine("\nDaily Step Rankings (High to Low):");
        PrintSteps(steps);

        // Last-minute update
        Console.WriteLine("\nUser synced extra steps...");
        steps[3] = steps[3] + 3000;

        BubbleSortOptimized(steps);

        Console.WriteLine("\nUpdated Rankings:");
        PrintSteps(steps);
    }

    static void BubbleSortOptimized(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                // Descending order for leaderboard
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // Optimization: stop if already sorted
            if (!swapped)
                break;
        }
    }

    static void PrintSteps(int[] steps)
    {
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine("Rank " + (i + 1) + ": " + steps[i] + " steps");
        }
    }
}

using System;

class StudentMarks
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        int[,] marks = GenerateMarks(studentCount);
        double[,] results = CalculateResults(marks);
        DisplayScorecard(marks, results);
    }

    static int[,] GenerateMarks(int count)
    {
        int[,] marks = new int[count, 3];
        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            marks[i, 0] = rand.Next(10, 101);
            marks[i, 1] = rand.Next(10, 101);
            marks[i, 2] = rand.Next(10, 101);
        }

        return marks;
    }

    static double[,] CalculateResults(int[,] marks)
    {
        int count = marks.GetLength(0);
        double[,] results = new double[count, 3];

        for (int i = 0; i < count; i++)
        {
            double total = (double)(marks[i, 0] + marks[i, 1] + marks[i, 2]);
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100.0;

            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    static void DisplayScorecard(int[,] marks, double[,] results)
    {
        int count = marks.GetLength(0);
        Console.WriteLine("\nStudent\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

        for (int i = 0; i < count; i++)
        {
            Console.Write("{0}\t{1}\t{2}\t\t{3}\t{4}\t{5}\t{6}\n",
                i + 1,
                marks[i, 0],
                marks[i, 1],
                marks[i, 2],
                results[i, 0],
                results[i, 1],
                results[i, 2]);
        }
    }
}

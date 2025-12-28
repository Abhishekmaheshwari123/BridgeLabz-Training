using System;

class MaxOfThree
{
    static int ReadInt()
    {
        return int.Parse(Console.ReadLine());
    }

    static int Max(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    public static void Main()
    {
        int a = ReadInt();
        int b = ReadInt();
        int c = ReadInt();

        Console.WriteLine("Maximum: " + Max(a, b, c));
    }
}

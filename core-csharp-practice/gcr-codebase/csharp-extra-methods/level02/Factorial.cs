using System;

class FactorialProgram
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Factorial(n - 1);
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(n));
    }
}

using System;

class Fibonacci
{
    static void PrintFibonacci(int terms)
    {
        int a = 0, b = 1;

        for (int i = 0; i < terms; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintFibonacci(n);
    }
}

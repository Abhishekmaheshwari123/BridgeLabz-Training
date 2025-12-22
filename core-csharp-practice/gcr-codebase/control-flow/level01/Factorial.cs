using System;
class Factorial
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        while(n != 1)
        {
            fact = (long) fact * n--;
        }

        Console.WriteLine(fact);
    }
}
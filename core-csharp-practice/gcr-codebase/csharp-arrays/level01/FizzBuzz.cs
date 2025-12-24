using System;
using System.Diagnostics;
class FizzBuzz
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n < 0)
        {
            Console.WriteLine("Enter a valid number");
            return ;
        }

        for(int i = 0; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
            else if(i % 3 == 0) Console.Write("Fizz ");
            else if(i % 5 == 0) Console.Write("Buzz ");
            else Console.Write(i+" ");
        }
    }
}
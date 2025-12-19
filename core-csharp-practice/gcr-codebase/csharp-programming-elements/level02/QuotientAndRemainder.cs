using System;
using System.Data;
class QuotientAndRemainder
{
    public static void Main(String[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int Quotient = a / b;
        int rem = a % b;
        Console.WriteLine("The Quotient is "+Quotient+" and Remainder is "+rem+" of two numbers " +a +" and "+b);
    }
}
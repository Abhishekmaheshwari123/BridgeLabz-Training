using System;
class PosNegZero
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n > 0) Console.WriteLine("Positive");
        else if(n < 0) Console.WriteLine("Negative");
        else Console.WriteLine("Zero");
    }
}
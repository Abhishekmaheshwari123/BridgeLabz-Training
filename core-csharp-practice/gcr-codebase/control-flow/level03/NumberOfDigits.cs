using System;
class NumberOfDigits
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n == 0) Console.WriteLine(1);
        else 
        Console.WriteLine((int)Math.Log10(n)+1);
    }
}
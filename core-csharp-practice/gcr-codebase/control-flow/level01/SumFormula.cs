using System;
class SumFormula
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n < 0)
        {
            Console.WriteLine("Please Enter a Natural Number");
        }
        long sum = (long) n * (n+1);
        sum /= 2;

        int dsum = 0;
        while(n > 0)
        {
            dsum += n--;
        }

        Console.WriteLine("Using Formula "+sum+"   using While loop "+dsum);
    }
}
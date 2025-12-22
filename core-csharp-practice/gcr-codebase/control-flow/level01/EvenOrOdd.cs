using System;
class EvenOrOdd
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            if(i % 2 == 0) Console.WriteLine(i+" is even");
            else Console.WriteLine(i+" is odd");
        }
    }
}
using System;
class SumOfN
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = recursive(n);
        int fsum = usingFormula(n);

        Console.WriteLine("recursive sum = "+sum +"   formula sum = "+fsum);
    }

    static int recursive(int n)
    {
        if(n <= 1)  return n;
        return n + recursive(n-1);
    }

    static int usingFormula(int n)
    {
        return (n * (n+1)) / 2;
    }
}
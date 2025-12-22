using System;
class SumOfN
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n > 0)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++) sum += i;
            Console.WriteLine("The sum of "+n+" natural numbers is "+sum);
        }
        else
        {
            Console.WriteLine("The number "+n+" is not a natural number");
        }
    }
}
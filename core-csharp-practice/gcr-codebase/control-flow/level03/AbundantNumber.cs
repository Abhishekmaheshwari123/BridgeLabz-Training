using System;
class AbundantNumber
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int temp = n;
        for(int i = 1; i < n; i++)
        {
           if(n % i == 0) sum += i;
        }

        if(temp < sum ) Console.WriteLine("Abundant Number ");
        else Console.WriteLine("Not a Abundant Number");

    }
}
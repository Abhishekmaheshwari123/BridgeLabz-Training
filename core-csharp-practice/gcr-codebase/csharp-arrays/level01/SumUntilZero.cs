using System;
class SumUntilZero
{
    public static void Main(String[]args)
    {
        int sum = 0;
        while(true)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 0) break;
            sum += n;
        }
        Console.WriteLine(sum);
    }
}
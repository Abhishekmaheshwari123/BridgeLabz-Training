using System;
class SumUntilZero
{
    public static void Main(String[] args)
    {
        double sum = 0.0;
        while(true)
        {
            double ele = double.Parse(Console.ReadLine());
            if(ele == 0.0) break;
            sum += ele;
        }

        Console.WriteLine(sum);
    }
}
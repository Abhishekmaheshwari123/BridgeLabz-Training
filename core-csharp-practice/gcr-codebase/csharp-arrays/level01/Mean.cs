using System;
class Mean
{
    public static void Main(String[]args)
    {
        int sum = 0;
        for(int i = 0; i < 11; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }

        double mean = (double) sum / 11;

        Console.WriteLine(mean);


    }
}
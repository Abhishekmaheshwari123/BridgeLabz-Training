using System;

class Date
{
    public static void Main(string[] args)
    {
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime result = date
            .AddDays(7)
            .AddMonths(1)
            .AddYears(2)
            .AddDays(-21); 

        Console.WriteLine("Final Date: " + result);
    }
}

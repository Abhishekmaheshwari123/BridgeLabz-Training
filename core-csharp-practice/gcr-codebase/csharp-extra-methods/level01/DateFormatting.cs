using System;

class DateFormatting
{
    public static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        Console.WriteLine(now.ToString("dd/MM/yyyy"));
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
        Console.WriteLine(now.ToString("ddd, MMM dd, yyyy"));
    }
}

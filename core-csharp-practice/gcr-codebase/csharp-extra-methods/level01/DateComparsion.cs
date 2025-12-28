using System;

class Program
{
    public static void Main(string[] args)
    {
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        DateTime d2 = DateTime.Parse(Console.ReadLine());

        int result = DateTime.Compare(d1, d2);

        if (result < 0)
            Console.WriteLine("First date is before second date");
        else if (result > 0)
            Console.WriteLine("First date is after second date");
        else
            Console.WriteLine("Both dates are the same");
    }
}

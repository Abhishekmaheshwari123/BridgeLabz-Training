using System;
using System.Security.Principal;
class NumberOfHandShakes
{
    public static void Main(String[] args)
    {
        int Students = Convert.ToInt32(Console.ReadLine());
        long TotalHandShakes = (long) Students * (Students - 1);
        TotalHandShakes /= 2;
        Console.WriteLine(TotalHandShakes);
    }
}
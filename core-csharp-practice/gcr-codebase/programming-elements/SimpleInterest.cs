using System;
class SimpleInterest
{
    public static void Main(string[] args)
    {
        double principal = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());

        double amount = (principal * rate * time) / 100;

        Console.WriteLine(amount);
    }
}
using System;
class SimpleInterest
{
    public static void Main(String[] args)
    {
        int principal = int.Parse(Console.ReadLine());
        int rate = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());

        double SI = CalculateSimpleInterest(principal , rate , time);

        Console.WriteLine("Simple Interest is "+ SI + " for Principal "+ principal+ " , Rate of Interest "+rate +" and Time "+time);
    }

    public static double CalculateSimpleInterest(int principal , int rate , int time)
    {
        double SI = (principal * rate * time) / 100.0;

        return SI;
    }
}
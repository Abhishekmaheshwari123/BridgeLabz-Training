using System;
class UnitConverter
{
    public static void Main(String[]args)
    {
        Console.WriteLine(Converter.KilotoMiles(10));
        Console.WriteLine(Converter.MilesToKilo(77));
        Console.WriteLine(Converter.MeterstoFeet(56));
        Console.WriteLine(Converter.FeetToMeters(45));
    }
}
class Converter
{
    public static double KilotoMiles(double dis)
    {
        return dis * 0.621371;
    }

    public static double MilesToKilo(double dis)
    {
        return dis * 1.60934;
    }

    public static double MeterstoFeet(double dis)
    {
        return dis *  3.28084;
    }

    public static double FeetToMeters(double dis)
    {
        return dis *  3.28084;
    }
}

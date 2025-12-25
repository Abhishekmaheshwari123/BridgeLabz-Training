using System;
class UnitConverter2
{
    public static void Main(String[]args)
    {
        Console.WriteLine(Converter.YardsToFeet(10));
        Console.WriteLine(Converter.FeetToYards(77));
        Console.WriteLine(Converter.MeterstoInches(56));
        Console.WriteLine(Converter.InchesToMeter(45));
        Console.WriteLine(Converter.InchesToCentiMeter(45));
    }
}
class Converter
{
    public static double YardsToFeet(double dis)
    {
        return dis * 3;
    }

    public static double FeetToYards(double dis)
    {
        return dis * 0.333;
    }

    public static double MeterstoInches(double dis)
    {
        return dis *  39.3701;
    }

    public static double InchesToMeter(double dis)
    {
        return dis *  0.0254;

    }
    public static double InchesToCentiMeter(double dis)
    {
        return dis *  2.54;
    }
}

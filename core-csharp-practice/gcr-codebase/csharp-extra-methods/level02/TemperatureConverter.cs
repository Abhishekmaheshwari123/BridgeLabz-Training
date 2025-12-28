using System;

class TemperatureConverter
{
    static double ToCelsius(double f)
    {
        return (f - 32) * 5 / 9.0;
    }

    static double ToFahrenheit(double c)
    {
        return (c * 9 / 5.0) + 32;
    }

    public static void Main()
    {
        double temp = double.Parse(Console.ReadLine());
        Console.WriteLine(ToCelsius(temp));
        Console.WriteLine(ToFahrenheit(temp));
    }
}

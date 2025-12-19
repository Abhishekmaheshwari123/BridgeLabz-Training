using System;

class TemperatureConversion
{
    public static void Main()
    {
        double Celsius = Convert.ToDouble(Console.ReadLine());
        double FahrenheitResult = (celsius * 9 / 5) + 32;
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");


    }
}

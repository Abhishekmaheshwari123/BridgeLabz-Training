using System;
class UnitConverter3
{
    public static void Main(String[]args)
    {
        Console.WriteLine(Converter.convertFarhenheitToCelsius(10));
        Console.WriteLine(Converter.ConvertCelsiusToFahrenheit(77));
        Console.WriteLine(Converter.PoundsToKg(56));
        Console.WriteLine(Converter.KgToPound(45));
        Console.WriteLine(Converter.GallonToLitre(65));
        Console.WriteLine(Converter.LiterToGallon(76));
    }
}
class Converter
{
    public static double convertFarhenheitToCelsius(double farh)
    {
        return (farh - 32) * 5 / 9;

    }

    public static double ConvertCelsiusToFahrenheit(double cel)
    {
        return (cel * 9 / 5) + 32;
    }

    public static double PoundsToKg(double weigth)
    {
        return weigth *  0.453592;
    }

    public static double KgToPound(double weight)
    {
        return  weight * 2.20462; 


    }
    public static double GallonToLitre(double leter)
    {
        return leter * 3.78541; 
    }
    public static double LiterToGallon(double Gallon)
    {
        return Gallon* 0.264172; 
    }
}

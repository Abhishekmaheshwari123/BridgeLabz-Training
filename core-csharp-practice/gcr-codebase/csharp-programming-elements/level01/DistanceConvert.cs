using System;
class DistanceConvert
{
    public static void Main(String []args)
    {
        double DistInKm = 10.8;

        double DistInMiles = 0.6 * DistInKm;

        Console.WriteLine("The distance"+DistInKm +"km in miles is" + DistInMiles);
    }
}
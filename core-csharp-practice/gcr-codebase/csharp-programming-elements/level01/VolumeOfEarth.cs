using System;
class VolumeOfEarth
{
    public static void Main(String []args)
    {
        double Radius = 6378;
        double VolumeInCubicKm = 4 * 3.14 * Radius * Radius * Radius;
        VolumeInCubicKm /= 3;

        double VolumeInCubicMiles = VolumeInCubicKm / (0.6213 * 0.6213 * 0.6213);
        Console.WriteLine("The volume of earth in cubic kilometers is "+VolumeInCubicKm+" and cubic miles is "+VolumeInCubicMiles);
    }
}
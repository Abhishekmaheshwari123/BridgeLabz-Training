using System;

class YardDistanceConvert
{
    public static void Main(String[] args)
    {
        float DistanceInFeet = float.Parse(Console.ReadLine());
        float DistanceInYards = DistanceInFeet / 3;
        float DistanceInMiles = DistanceInFeet / 5280;   // 1760 yards = 5280 feets
        Console.WriteLine("Distance in yards is " + DistanceInYards +" and distance in miles is " + DistanceInMiles);
    }
}

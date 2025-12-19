using System;

class DistanceConversion
{
    static void Main()
    {
        // Read distance in feet
        float distanceInFeet = float.Parse(Console.ReadLine());

        // Convert feet to yards
        float distanceInYards = distanceInFeet / 3;

        // Convert feet to miles
        float distanceInMiles = distanceInFeet / 5280;

        // Output
        Console.WriteLine(
            "Distance in yards is " + distanceInYards +
            " and distance in miles is " + distanceInMiles
        );
    }
}

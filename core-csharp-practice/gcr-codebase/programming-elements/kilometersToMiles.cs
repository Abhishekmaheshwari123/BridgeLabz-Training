using System;
public class kilometersToMiles
{
    public static void Main(string [] args)
    {
        int disInKm = Convert.ToInt32(Console.ReadLine());
        double inMiles = 0.63 * disInKm;

        Console.WriteLine(inMiles);
    }
}
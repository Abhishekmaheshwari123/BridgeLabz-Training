using System;
class CityAndTime
{
    public static void Main(String []args)
    {
        String Name = Console.ReadLine();
        String FromCity = Console.ReadLine();
        String ViaCity = Console.ReadLine();
        String ToCity = Console.ReadLine();

        int DistFromToVia = Convert.ToInt32(Console.ReadLine());
        int DistViaToFinalCity = Convert.ToInt32(Console.ReadLine());

        int TimeTakenFromToVia = Convert.ToInt32(Console.ReadLine());
        int TimeTakenViaToFinal = Convert.ToInt32(Console.ReadLine());

        double TotalDistance = DistFromToVia + DistViaToFinalCity;

        double TotalTime = TimeTakenFromToVia + TimeTakenViaToFinal;


        Console.WriteLine("Total Distance From "+FromCity+" to "+ToCity+" is "+TotalDistance);
        Console.WriteLine("Total time From "+FromCity+" to "+ToCity+" is "+TotalTime);
    }
}
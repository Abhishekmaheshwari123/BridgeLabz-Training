using System;

class TrafficManager
{
    static void Main()
    {
        Roundabout roundabout = new Roundabout();
        WaitingQueue queue = new WaitingQueue(3);

        // Vehicles arriving
        queue.Enqueue(101);
        queue.Enqueue(102);
        queue.Enqueue(103);
        queue.Enqueue(104);   // Overflow case

        // Move vehicles from queue to roundabout
        int vehicleId;
        while ((vehicleId = queue.Dequeue()) != -1)
        {
            roundabout.AddVehicle(vehicleId);
        }

        roundabout.PrintRoundabout();

        // Vehicles exiting
        roundabout.RemoveVehicle(102);
        roundabout.PrintRoundabout();

        roundabout.RemoveVehicle(101);
        roundabout.PrintRoundabout();
    }
}

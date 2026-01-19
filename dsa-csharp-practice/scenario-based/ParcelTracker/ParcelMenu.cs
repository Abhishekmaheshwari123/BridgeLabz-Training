using System;

public class ParcelMenu
{
    private ParcelUtility utility = new ParcelUtility();

    public void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Parcel Tracking Menu ---");
            Console.WriteLine("1. Add Delivery Stage");
            Console.WriteLine("2. Add Checkpoint");
            Console.WriteLine("3. Track Parcel");
            Console.WriteLine("4. Mark Parcel Lost");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter stage name: ");
                    utility.AddStage(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter existing stage: ");
                    string afterStage = Console.ReadLine();
                    Console.Write("Enter checkpoint name: ");
                    string newStage = Console.ReadLine();
                    utility.AddCheckpoint(afterStage, newStage);
                    break;

                case 3:
                    utility.TrackParcel();
                    break;

                case 4:
                    Console.Write("Enter stage after which parcel is lost: ");
                    utility.MarkLostAfter(Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine("Exiting Parcel Tracker...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}

using System;

class Vehicle
{
    public string OwnerName;
    public string VehicleType;

    // class variable
    public static double RegistrationFee = 1500;

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + OwnerName +
                          ", Vehicle: " + VehicleType +
                          ", Registration Fee: " + RegistrationFee);
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle("Abhi", "Bike");
        Vehicle v2 = new Vehicle("Riya", "Car");

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        Console.WriteLine("\nUpdating registration fee...\n");
        Vehicle.UpdateRegistrationFee(2000);

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}

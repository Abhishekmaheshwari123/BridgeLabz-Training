using System;

class Vehicle
{
    public static double RegistrationFee = 1500;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string regNo, string owner, string type)
    {
        this.RegistrationNumber = regNo;
        this.OwnerName = owner;
        this.VehicleType = type;
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }

    public void ShowVehicle()
    {
        if (this is Vehicle)
        {
            Console.WriteLine("Registration No: " + RegistrationNumber);
            Console.WriteLine("Owner: " + OwnerName);
            Console.WriteLine("Type: " + VehicleType);
            Console.WriteLine("Fee: " + RegistrationFee);
        }
    }

    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle("REG123", "Abhi", "Car");

        v1.ShowVehicle();

        Console.WriteLine("\nUpdating Fee...\n");
        Vehicle.UpdateRegistrationFee(2000);

        v1.ShowVehicle();
    }
}

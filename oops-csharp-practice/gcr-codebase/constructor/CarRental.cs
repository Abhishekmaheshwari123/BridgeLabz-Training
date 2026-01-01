using System;

class CarRental
{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;
    public double TotalCost;

    double pricePerDay = 1200;

    public CarRental()
    {
        CustomerName = "Unknown";
        CarModel = "Unknown";
        RentalDays = 0;
        TotalCost = 0;
    }

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        TotalCost = rentalDays * pricePerDay;
    }

    static void Main(string[] args)
    {
        CarRental r1 = new CarRental();
        Console.WriteLine(r1.CustomerName + " - " + r1.CarModel + " - " + r1.TotalCost);

        CarRental r2 = new CarRental("Abhi", "Swift", 5);
        Console.WriteLine(r2.CustomerName + " - " + r2.CarModel + " - " + r2.TotalCost);
    }
}

using System;
using System.Collections.Generic;

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set { rentalRate = value; }
    }

    public Vehicle(string num, string t, double rate)
    {
        VehicleNumber = num;
        Type = t;
        RentalRate = rate;
    }

    public abstract double CalculateRentalCost(int days);
}

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

class Car : Vehicle, IInsurable
{
    public Car(string n, double r) : base(n, "Car", r) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return 1000;
    }

    public string GetInsuranceDetails()
    {
        return "Standard insurance";
    }
}

class Bike : Vehicle, IInsurable
{
    public Bike(string n, double r) : base(n, "Bike", r) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }

    public double CalculateInsurance()
    {
        return 300;
    }

    public string GetInsuranceDetails()
    {
        return "Basic insurance";
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck(string n, double r) : base(n, "Truck", r) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate + 2000;
    }

    public double CalculateInsurance()
    {
        return 2000;
    }

    public string GetInsuranceDetails()
    {
        return "Heavy vehicle insurance";
    }
}

class Program3
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car("C1", 2000));
        vehicles.Add(new Bike("B1", 500));
        vehicles.Add(new Truck("T1", 5000));

        foreach (Vehicle v in vehicles)
        {
            Console.WriteLine("Rental: " + v.CalculateRentalCost(3));

            IInsurable ins = v as IInsurable;
            if (ins != null)
            {
                Console.WriteLine("Insurance: " + ins.CalculateInsurance());
            }
        }
    }
}

using System;
using System.Collections.Generic;

abstract class RideVehicle
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    public RideVehicle(int id, string d, double rate)
    {
        VehicleId = id;
        DriverName = d;
        RatePerKm = rate;
    }

    public abstract double CalculateFare(double distance);

    public string GetVehicleDetails()
    {
        return "ID: " + VehicleId + " Driver: " + DriverName;
    }
}

interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string loc);
}

class RideCar : RideVehicle, IGPS
{
    private string location;

    public RideCar(int id, string d, double r) : base(id, d, r) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }
}

class RideBike : RideVehicle, IGPS
{
    private string location;

    public RideBike(int id, string d, double r) : base(id, d, r) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }
}

class RideAuto : RideVehicle, IGPS
{
    private string location;

    public RideAuto(int id, string d, double r) : base(id, d, r) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm + 20;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string loc)
    {
        location = loc;
    }
}

class Program8
{
    static void Main()
    {
        List<RideVehicle> rides = new List<RideVehicle>();
        rides.Add(new RideCar(1, "A", 10));
        rides.Add(new RideBike(2, "B", 5));
        rides.Add(new RideAuto(3, "C", 8));

        foreach (RideVehicle v in rides)
        {
            Console.WriteLine(v.GetVehicleDetails());
            Console.WriteLine("Fare: " + v.CalculateFare(10));
        }
    }
}

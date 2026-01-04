using System;

class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(MaxSpeed + " " + FuelType);
    }
}

class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(MaxSpeed + " " + FuelType + " " + SeatCapacity);
    }
}

class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(MaxSpeed + " " + FuelType + " " + PayloadCapacity);
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(MaxSpeed + " " + FuelType + " " + HasSidecar);
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] v = new Vehicle[3];
        v[0] = new Car();
        v[0].MaxSpeed = 180;
        v[0].FuelType = "Petrol";
        ((Car)v[0]).SeatCapacity = 4;

        v[1] = new Truck();
        v[1].MaxSpeed = 120;
        v[1].FuelType = "Diesel";
        ((Truck)v[1]).PayloadCapacity = 5000;

        v[2] = new Motorcycle();
        v[2].MaxSpeed = 150;
        v[2].FuelType = "Petrol";
        ((Motorcycle)v[2]).HasSidecar = true;

        for (int i = 0; i < v.Length; i++)
        {
            v[i].DisplayInfo();
        }
    }
}

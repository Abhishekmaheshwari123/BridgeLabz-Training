using System;

interface IRentable
{
    double CalculateRent(int days);
}

abstract class Vehicle : IRentable
{
    protected string vehicleNumber;
    protected string model;
    protected double rentPerDay;

    public Vehicle(string vehicleNumber, string model, double rentPerDay)
    {
        this.vehicleNumber = vehicleNumber;
        this.model = model;
        this.rentPerDay = rentPerDay;
    }

    public abstract double CalculateRent(int days);

    public virtual void ShowDetails()
    {
        Console.WriteLine("Model: "+model+"  Number: "+ vehicleNumber+",  Rent/Day: "+rentPerDay);
    }
}

class Bike : Vehicle
{
    public Bike(string number, string model, double rentPerDay)
        : base(number, model, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        return rentPerDay * days;
    }
}

class Car : Vehicle
{
    public Car(string number, string model, double rentPerDay)
        : base(number, model, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        // Example: discount after 5 days
        double total = rentPerDay * days;
        if (days > 5) total *= 0.95;
        return total;
    }
}

class Truck : Vehicle
{
    public Truck(string number, string model, double rentPerDay)
        : base(number, model, rentPerDay) { }

    public override double CalculateRent(int days)
    {
        // Example: extra heavy-vehicle charge
        return (rentPerDay * days) + 500;
    }
}

class Customer
{
    protected string name;
    protected string phone;

    public Customer(string name, string phone)
    {
        this.name = name;
        this.phone = phone;
    }

    public void ShowCustomer()
    {
        Console.WriteLine("Customer: "+name+"   Phone: "+ phone);
    }
}

class Program
{
    static void Main()
    {
        Customer c = new Customer("Abhishek", "9999999999");

        Vehicle bike = new Bike("BK01", "Honda Shine", 200);
        Vehicle car = new Car("CR21", "Hyundai i20", 1200);
        Vehicle truck = new Truck("TR55", "Ashok Leyland", 2500);

        c.ShowCustomer();
        Console.WriteLine();

        bike.ShowDetails();
        Console.WriteLine("Rent (3 days): " + bike.CalculateRent(3));

        Console.WriteLine();

        car.ShowDetails();
        Console.WriteLine("Rent (7 days): " + car.CalculateRent(7));

        Console.WriteLine();

        truck.ShowDetails();
        Console.WriteLine("Rent (4 days): " + truck.CalculateRent(4));
    }
}

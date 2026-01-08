using System;

// Interface
interface IControllable
{
    void TurnOn();
    void TurnOff();
}

// Abstract base class
abstract class Appliance : IControllable
{
    public string Name { get; private set; }

    protected Appliance(string name)
    {
        Name = name;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}

// Light class
class Light : Appliance
{
    public Light(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " light is glowing");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " light is turned off");
    }
}

// Fan class
class Fan : Appliance
{
    public Fan(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " fan is rotating");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " fan is turned off");
    }
}

// AC class
class AC : Appliance
{
    public AC(string name) : base(name) { }

    public override void TurnOn()
    {
        Console.WriteLine(Name + " AC is cooling");
    }

    public override void TurnOff()
    {
        Console.WriteLine(Name + " AC is turned off");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Appliance[] appliances =
        {
            new Light("Living Room"),
            new Fan("Bedroom"),
            new AC("Office")
        };

        Console.WriteLine("Turning ON all appliances:\n");
        foreach (Appliance appliance in appliances)
        {
            appliance.TurnOn();
        }

        Console.WriteLine("\nTurning OFF all appliances:\n");
        foreach (Appliance appliance in appliances)
        {
            appliance.TurnOff();
        }
    }
}

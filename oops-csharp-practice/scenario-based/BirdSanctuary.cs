using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

public class Bird
{
    public string Name;
    public string Species;

    public Bird(string name, string species)
    {
        Name = name;
        Species = species;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Bird: " + Name + " | Species: " + Species);
    }
}

// -------- Derived Birds --------

public class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name, "Eagle") {}

    public void Fly()
    {
        Console.WriteLine(Name + " is soaring high in the sky.");
    }
}

public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name, "Sparrow") {}

    public void Fly()
    {
        Console.WriteLine(Name + " is flying quickly from tree to tree.");
    }
}

public class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name, "Duck") {}

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming gracefully on the pond.");
    }
}

public class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name, "Penguin") {}

    public void Swim()
    {
        Console.WriteLine(Name + " is swimming under the cold water.");
    }
}

public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name, "Seagull") {}

    public void Fly()
    {
        Console.WriteLine(Name + " is flying over the ocean.");
    }

    public void Swim()
    {
        Console.WriteLine(Name + " is floating on the sea.");
    }
}

class Program
{
    public static void Main()
    {
        // Array of Birds
        Bird[] sanctuary = new Bird[5];

        sanctuary[0] = new Eagle("Hunter");
        sanctuary[1] = new Sparrow("Chirpy");
        sanctuary[2] = new Duck("Donald");
        sanctuary[3] = new Penguin("Pingu");
        sanctuary[4] = new Seagull("Wings");

        // -------- POLYMORPHISM --------
        Console.WriteLine("=== Bird Sanctuary Activities ===");

        for (int i = 0; i < sanctuary.Length; i++)
        {
            sanctuary[i].DisplayInfo();

            if (sanctuary[i] is IFlyable)
            {
                ((IFlyable)sanctuary[i]).Fly();
            }

            if (sanctuary[i] is ISwimmable)
            {
                ((ISwimmable)sanctuary[i]).Swim();
            }

            Console.WriteLine("--------------------------------");
        }
    }
}

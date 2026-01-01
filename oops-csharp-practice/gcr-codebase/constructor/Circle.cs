using System;

class Circle
{
    public double Radius;

    public Circle() : this(1.0)
    {
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    static void Main(string[] args)
    {
        Circle c1 = new Circle();
        Console.WriteLine("Default Radius: " + c1.Radius);

        Circle c2 = new Circle(5.5);
        Console.WriteLine("Custom Radius: " + c2.Radius);
    }
}

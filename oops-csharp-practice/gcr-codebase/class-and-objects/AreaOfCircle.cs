using System;
class AreaOfCircle
{
    public static void Main(String[] args)
    {
        Circle c = new Circle(4);

        Console.WriteLine("Area of circle  : "+c.Area(4));
        Console.WriteLine("Perimeter of circle  : "+c.Perimeter(4));

    }
}

public class Circle
{
    int radius;
    public Circle(int Radius)
    {
        radius = Radius;
    }

    public double Area(int radius)
    {
        return Math.PI*radius*radius;
    }

    public double Perimeter(int radius)
    {
        return Math.PI * 2 * radius;
    }
}
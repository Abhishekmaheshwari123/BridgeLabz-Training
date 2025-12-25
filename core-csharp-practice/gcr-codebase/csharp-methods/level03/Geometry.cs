using System;

class Geometry
{
    static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = GetDistance(x1, y1, x2, y2);
        Console.WriteLine("\nEuclidean Distance: " + distance);

        double[] line = GetLineEquation(x1, y1, x2, y2);

        Console.WriteLine("Slope (m): " + line[0]);
        Console.WriteLine("Y-Intercept (b): " + line[1]);

        Console.WriteLine("\nEquation of Line:  y = " + line[0] + "x + " + line[1]);

    }
    public static double GetDistance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;

        double distance = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

        return distance;
    }
    public static double[] GetLineEquation(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2)
        {
            Console.WriteLine("\nThis is a vertical line: x = " + x1);
            return new double[] { double.PositiveInfinity, double.NaN };
        }

        double m = (y2 - y1) / (x2 - x1); 
        double b = y1 - (m * x1);         

        return new double[] { m, b };
    }
}

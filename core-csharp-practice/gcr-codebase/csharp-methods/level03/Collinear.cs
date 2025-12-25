using System;

class Collinear
{
    static void Main(string[] args)
    {
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        bool slopeResult = AreCollinearSlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = AreCollinearArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Using slope method: " + slopeResult);
        Console.WriteLine("Using area method: " + areaResult);
    }

    static bool AreCollinearSlope(double x1, double y1,double x2, double y2, double x3, double y3)
    {
        double slopeAB = (x2 - x1) == 0 ? double.PositiveInfinity : (y2 - y1) / (x2 - x1);
        double slopeBC = (x3 - x2) == 0 ? double.PositiveInfinity : (y3 - y2) / (x3 - x2);
        double slopeAC = (x3 - x1) == 0 ? double.PositiveInfinity : (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    static bool AreCollinearArea(double x1, double y1,double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        return area == 0;
    }
}

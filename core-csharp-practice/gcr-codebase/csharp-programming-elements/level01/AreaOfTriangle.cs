using System;

class AreaOfTriangle
{
    static void Main()
    {
        float baseInInches = float.Parse(Console.ReadLine());
        float heightInInches = float.Parse(Console.ReadLine());
        float AreaInSqInches = 0.5f * baseInInches * heightInInches;
        float AreaInSqCm = AreaInSqInches * 6.4516f;
        Console.WriteLine("Area of Triangle is " + AreaInSqInches + " square inches and " + AreaInSqCm + " square centimeters");
    }
}

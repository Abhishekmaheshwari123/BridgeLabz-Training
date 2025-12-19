using System;
class TriangularPark
{
    public static void Main(String []args)
    {
        double perimeter = Convert.ToDouble(Console.ReadLine());
        perimeter /= 100;

        double rounds = 5/perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is "+rounds+ " to complete 5 km");
    }
}
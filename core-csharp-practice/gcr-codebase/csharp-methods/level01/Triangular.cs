using System;
class Triangular
{
    public static void Main(string[]args)
    {
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());
        int perimeter = side1 + side2 + side3;

        int rounds = 5000 / perimeter;

        Console.WriteLine(rounds);
    }
}
using System;
class Perimeter
{
    public static void Main(String[] args)
    {
        int length = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());

        int peri = 2 * (length + width);

        Console.WriteLine(peri);
    }
}
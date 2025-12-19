using System;
class HeightConvert
{
    public static void  Main(String[] args)
    {
        int HeightCm = Convert.ToInt32(Console.ReadLine());
        double HeightInches = 0.41 * HeightCm;
        double HeightFoot = HeightInches / 12;

        Console.WriteLine("Your Height in cm is "+HeightCm+ " while in feet is "+ HeightFoot+" and inches is "+HeightInches);

    }
}
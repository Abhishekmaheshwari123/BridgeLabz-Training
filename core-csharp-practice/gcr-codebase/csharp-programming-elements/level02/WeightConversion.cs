using System;
class WeightConversion
{
    public static void Main(String[] args)
    {
        int weight = Convert.ToInt32(Console.ReadLine());

        double weightInKg = weight * 2.2;

        Console.WriteLine("The weight of the person in pounds is "+weight+" and in kg is "+weightInKg);
    }
}
using System;
class ProductPrices
{
    public static void Main(String []args)
    {
        int NetPrice = Convert.ToInt32(Console.ReadLine());
        int Quantity = Convert.ToInt32(Console.ReadLine());

        int TotalCost = NetPrice * Quantity;

        Console.WriteLine("The total purchase price is INR "+TotalCost+" if the quantity "+Quantity+" and unit price is INR "+NetPrice);
    }
}
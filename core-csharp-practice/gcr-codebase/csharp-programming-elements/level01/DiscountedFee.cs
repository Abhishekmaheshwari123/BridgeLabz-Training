using System;
class DiscountedFee
{
    public static void Main(String []args)
    {
        int Fee = 125000;
        double DiscountedAmount = 0.1 * Fee;
        double DiscountedFee = Fee - DiscountedAmount;

        Console.WriteLine("The discount amount is INR "+DiscountedAmount+" and final discounted fee is INR "+DiscountedFee);
    }
}
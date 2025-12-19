using System;
class DiscountFeeWithInput
{
    public static void Main(String []args)
    {
        int Fee = Convert.ToInt32(Console.ReadLine());
        double UniversityDiscount = Convert.ToDouble(Console.ReadLine());
        double DiscountedAmount = (UniversityDiscount/100) * Fee;
        double DiscountedFee = Fee - DiscountedAmount;

        Console.WriteLine("The discount amount is INR "+DiscountedAmount+" and final discounted fee is INR "+DiscountedFee);
    }
}
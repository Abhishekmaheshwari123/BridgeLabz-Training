using System;
class ProfitOrLoss
{
    public static void Main(String []args)
    {
        int CostPrice = 129;
        int SellingPrice = 191;

        int Profit = SellingPrice - CostPrice ;

        double ProfitPercetage = (Profit * 100 / CostPrice) ;

        Console.WriteLine("The Cost Price is INR "+CostPrice+" and Selling Price is INR "+SellingPrice);
        Console.WriteLine("The Profit is INR "+Profit+" and the Profit Percentage is "+ProfitPercetage+"%");
    }
}
using System;
class SimpleInterest
{
    public static void Main(String []args)
    {
        int Pricipal = Convert.ToInt32(Console.ReadLine());
        int Rate = Convert.ToInt32(Console.ReadLine());
        int Time = Convert.ToInt32(Console.ReadLine());

        int totalAmount = (Pricipal * Rate * Time) / 100;

        Console.WriteLine("The Simple Interest is "+totalAmount+" for Principal "+Pricipal+" ,Rate of Interest "+Rate+" and Time "+Time);
    }
}
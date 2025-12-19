using System;
class Chocolate
{
    public static void Main(String []args)
    {
        int Chocolate = Convert.ToInt32(Console.ReadLine());

        int students = Convert.ToInt32(Console.ReadLine());

        int EachGet = Chocolate / students;

        int remain = Chocolate % students;


        Console.WriteLine("The number of chocolates each child gets is "+EachGet+" and the number of remaining chocolates is "+remain);
    }
}
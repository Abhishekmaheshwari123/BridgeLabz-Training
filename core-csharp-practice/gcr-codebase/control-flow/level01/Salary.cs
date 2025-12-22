using System;
class Salary
{
    public static void Main(String[] args)
    {
        int salary = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        if(year >= 5)
        {
            int bonusAmount = (salary * 5) / 100;
            Console.WriteLine(bonusAmount) ;
        }
        else Console.WriteLine("Please complete atleast 5 years of service");
    }
}
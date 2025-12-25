using System;
class LeapYear
{
    public static void Main(String[]args)
    {
        int year = int.Parse(Console.ReadLine());

        bool flg = canLeapYear(year);

        if(flg) Console.WriteLine("Yes it is a Leap Year");
        else Console.WriteLine("No it is not a Leap Year");
    }

    static Boolean canLeapYear(int year)
    {
        if(year < 1582) return false;
        if(year % 100 == 0 || year % 400 == 0) return false;
        return true;
    }
}
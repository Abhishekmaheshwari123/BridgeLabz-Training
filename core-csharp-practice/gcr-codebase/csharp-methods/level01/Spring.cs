using System;
class Spring
{
    public static void Main(String[]args)
    {
        int date = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        bool flg = solve(date , month);

        if(flg) Console.WriteLine("It's Spring Season");
        else Console.WriteLine("Not a Spring Season");
    }

    public static Boolean solve(int date, int month)
    {
        if(date >= 31 || date < 0) return false;
        if(month == 3 && date>= 20 ||
            month == 4 ||
            month == 5 ||
            month == 6 && date <= 20) return true;

        return false;
    }
}
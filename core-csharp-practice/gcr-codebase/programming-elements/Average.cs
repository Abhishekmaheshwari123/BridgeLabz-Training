using System;
class Average{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        double ans = (a + b + c) / 3;
        Console.WriteLine(ans);
    }
}
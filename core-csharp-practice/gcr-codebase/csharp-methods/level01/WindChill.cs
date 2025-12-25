using System;
class WindChill
{
    public static void Main(String[] args)
    {
        double temp = double.Parse(Console.ReadLine());
        double WindSpeed = double.Parse(Console.ReadLine());

        double ans = solve(temp , WindSpeed);
        Console.WriteLine(ans);
    }

    static double solve(double temp, double WindSpeed)
    {
        return 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * WindSpeed*0.16 ;

    }
}
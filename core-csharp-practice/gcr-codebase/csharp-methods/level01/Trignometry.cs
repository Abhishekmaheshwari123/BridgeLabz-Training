using System;
class Trignometry
{
    public static void Main(String[] args)
    {
        double angle = double.Parse(Console.ReadLine());
        double []ans = CalculateTrignometry(angle);

        Console.WriteLine("Sine "+ans[0]+"   Cosine "+ans[1]+"   Tangent "+ans[2]);
    }

    static double[] CalculateTrignometry(double angle)
    {
        double []ans = new double[3];
        double radian = angle * (Math.PI / 180);

        ans[0] = Math.Sin(radian);
        ans[1] = Math.Cos(radian);
        ans[2] = Math.Tan(radian);

        return ans;
    }
}
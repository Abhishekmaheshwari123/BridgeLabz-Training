using System;
public class Power
{
    public static void Main(string[] args)
    {
        int ba = Convert.ToInt32(Console.ReadLine());
        int exp = Convert.ToInt32(Console.ReadLine());

        int ans = (int) Math.Pow(ba,exp);
        Console.WriteLine(ans);
    }
}
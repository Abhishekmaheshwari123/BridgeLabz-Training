using System;
class PosNegZero
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());

        int ele = solve(n);

        if(ele == -1) Console.WriteLine("Negative");
        else if(ele == 1) Console.WriteLine("Positive");
        else Console.WriteLine("Zero");
    }

    public static int solve(int ele)
    {
        if(ele > 0) return 1;
        else if(ele < 0) return -1;
        return 0;
    }
}
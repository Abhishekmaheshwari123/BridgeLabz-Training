using System;
class HandShakes
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int totalHandShakes = solve(n);
        Console.WriteLine(totalHandShakes);
    }

    static int solve(int n)
    {
        int ans = n * (n-1);
        return ans / 2;
    }
}
using System;

class Prime
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                return false;

        return true;
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
    }
}

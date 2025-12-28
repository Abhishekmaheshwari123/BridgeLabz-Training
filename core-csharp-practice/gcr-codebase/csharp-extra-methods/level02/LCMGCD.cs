using System;

class LCMGCD
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }

    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(a, b));
        Console.WriteLine("LCM: " + LCM(a, b));
    }
}

using System;
class Power
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        int ans = 1;
        for(int i = 0; i < power; i++) ans = ans * n;

        Console.WriteLine(ans);
    }
}
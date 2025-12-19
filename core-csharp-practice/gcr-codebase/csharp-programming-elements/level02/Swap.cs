using System;
class Swap
{
    public static void Main(String[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("Swapped Numbers "+a +", "+b);
    }
}
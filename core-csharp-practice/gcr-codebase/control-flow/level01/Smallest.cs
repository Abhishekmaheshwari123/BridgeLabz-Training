using System;
class SmallestOfThree
{
    public static void Main(String[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());        
        int c = int.Parse(Console.ReadLine());
        int Smallest = Math.Min(a , Math.Min(b , c));
        if(a == Smallest) Console.WriteLine("Yes the first number the smallest");
        Console.WriteLine("Not the first number the smallest");
    }
}
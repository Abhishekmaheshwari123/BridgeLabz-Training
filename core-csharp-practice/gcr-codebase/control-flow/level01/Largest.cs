using System;
class SmallestOfThree
{
    public static void Main(String[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());        
        int c = int.Parse(Console.ReadLine());
        int largest = Math.Max(a , Math.Max(b , c));
         Console.WriteLine("The largest number is "+largest);
    }
}
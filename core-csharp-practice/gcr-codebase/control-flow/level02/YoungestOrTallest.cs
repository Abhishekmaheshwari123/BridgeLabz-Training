using System;
class YoungestOrTallest
{
    public static void Main(String[] args)
    {
        int age1 = int.Parse(Console.ReadLine());
        int age2 = int.Parse(Console.ReadLine());
        int age3 = int.Parse(Console.ReadLine());

        int mini = Math.Min(age1 , Math.Min(age2 , age3));
        if(mini == age1) Console.WriteLine("Amar is youngest");
        else if(mini == age2) Console.WriteLine("Akbor is youngest");
        else Console.WriteLine("Anthony is youngest");


        int height1 = int.Parse(Console.ReadLine());
        int height2 = int.Parse(Console.ReadLine());
        int height3 = int.Parse(Console.ReadLine());

        int maxi = Math.Max(height1 , Math.Max(height2 , height3));
        if(maxi == height1) Console.WriteLine("Amar is tallest");
        else if(maxi == height2) Console.WriteLine("Akbor is tallest");
        else Console.WriteLine("Anthony is tallest");
    }
}
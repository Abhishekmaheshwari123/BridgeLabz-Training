using System;
class TallestYoungest
{
    public static void Main(string[]args)
    {
        string tall = Tallest();
        string youngest = Youngest();

        Console.WriteLine("Tallest : "+tall+"     youngest : "+youngest);
    }


    static string Tallest()
    {
        int h1 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int h3 = int.Parse(Console.ReadLine());

        int maxi = Math.Max(h1 , Math.Max(h2 , h3));

        if(h1 == maxi) return "Amar";
        else if(h2 == maxi) return "Akbar";
        return "anthony";
    }
    static string Youngest()
    {
        int a1 = int.Parse(Console.ReadLine());
        int a2 = int.Parse(Console.ReadLine());
        int a3 = int.Parse(Console.ReadLine());

        int mini = Math.Min(a1 , Math.Min(a2 , a3));

        if(a1 == mini) return "Amar";
        else if(a2 == mini) return "Akbar";
        return "anthony";
    }

}
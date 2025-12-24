using System;
class TallYoung
{
    public static void Main(String[]args)
    {
        int[,]arr = new int[3,2];
        int maxHeight = 0;
        int MinAge = 0;
        for(int i = 0; i < 3; i++)
        {
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            arr[i,0] = height;
            arr[i,1] = weight;
            maxHeight = Math.Max(maxHeight , arr[i,0]);
            MinAge = Math.Min(MinAge , arr[i,1]);
        }
        if(maxHeight == arr[0,0])Console.WriteLine("Amar Has Max Height");
        else if(maxHeight == arr[1,0])Console.WriteLine("Akbar Has Max Height");
        else Console.WriteLine("Anthony Has Max Height");

        if(MinAge == arr[0,1]) Console.WriteLine("Amar is youngest");
        else if(MinAge == arr[1,1]) Console.WriteLine("Akbar is youngest");
        else Console.WriteLine("Anthony is youngest");
    }
}
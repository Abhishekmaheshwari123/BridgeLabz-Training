using System;
class GreatestFactor
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        int ans = 0;
        for(int i = n-1; i >= 1; i--)
        {
            if(n % i == 0)
            {
                ans = i;
                break;
            }
        }
        Console.WriteLine("Greatest Factor of "+n +" is "+ans);
    }
}
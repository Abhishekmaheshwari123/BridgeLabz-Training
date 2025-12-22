using System;
using System.Data;
class Armstrong
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        int ans = n;
        int length = (int)Math.Log10(n) + 1;
        int temp = 0;
        while(n > 0)
        {
            temp += (int)Math.Pow(n%10 , length)   ;
            n /= 10;
        }

        if(temp == ans) Console.WriteLine("Armstrong");
        else Console.WriteLine("Not Armstrong");
    }
}
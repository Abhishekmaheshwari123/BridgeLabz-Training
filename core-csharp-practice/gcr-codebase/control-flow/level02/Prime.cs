using System;
class Prime
{
    public static void Main(String []args)
    {
        int n = int.Parse(Console.ReadLine());
        bool  flg = true;
        for(int i = 2; i*i <= n; i++)
        {
            if(n % i == 0){
                flg = false;
                break;
            }
        }

        if(flg)Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
    }
}
using System;
class Harshad
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int temp = n;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        if(temp % sum == 0) Console.WriteLine("Harshad Number");
        else Console.WriteLine("Not a Harshad Number");

    }
}
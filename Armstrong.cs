using System;
class Armstrong{
    public static void Main(string[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        int length = (int)Math.Log10(n)+1;
        int sum = 0;
        while(n > 0)
        {
            sum = sum + (int)Math.Pow(n%10 , length);
            n /= 10;
        }

        Console.WriteLine(temp == sum);
    }
}
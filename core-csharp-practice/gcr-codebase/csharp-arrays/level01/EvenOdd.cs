using System;
class EvenOdd
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        if(n <= 0)
        {
            Console.WriteLine("Enter a natural Number");
            return ;
        }

        int[] even = new int[n/2];
        int[] odd = new int[n % 2 == 0 ? n / 2 : (even.Length+1)];
        int evenPoint = 0;
        int oddPoint = 0;

        for(int i = 1; i <= n; i++)
        {
            if(i % 2 == 0) even[evenPoint++] = i;
            else odd[oddPoint++] = i;
        }
        Console.Write("even  ");
        foreach (int i in even)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
        Console.Write("odd   ");
        foreach (int i in odd)
        {
            Console.Write(i+" ");
        }

    }
}
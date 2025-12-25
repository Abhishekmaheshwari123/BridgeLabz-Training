using System;
class PosNegZero
{
    public static void Main(String[]args)
    {
        for(int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());
            bool pos = n > 0;
            Console.Write(pos ? "Positve   " : "negative   ");

            bool even = (n % 2 == 0);
            Console.Write(even ? "even   " : "odd   ");
        }
    }
}
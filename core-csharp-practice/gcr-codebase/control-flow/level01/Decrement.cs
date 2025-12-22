using System;
class Decrement
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        while(n != 1)
        {
            Console.WriteLine(n--);
        }

        for(int i = temp; i != 1; i--)
        {
            Console.WriteLine(i);
        }

        
    }
}
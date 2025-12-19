using System;
class Average
{
    public static void Main(String []args)
    {
        int Maths = 94;
        int Physics = 95;
        int Chemistry = 96;

        double Avg = (Maths + Physics + Chemistry) / 3;

        Console.WriteLine("Sam’s average mark in PCM is "+Avg);
    }
}
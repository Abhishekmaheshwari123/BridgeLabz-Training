using System;
using System.ComponentModel;
using System.Security.Principal;
class Table
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine(n + " * " + i + " = "+(i*n));
        }
    }
}
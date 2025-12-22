using System;
class Table
{
    public static void Main(String[] args)
    {   
        int n = int.Parse(Console.ReadLine());
        if(n <= 0) Console.WriteLine("Please Write a valid number");
        else
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+" * "+i+" = "+(n*i));
            }
        }
    }
}
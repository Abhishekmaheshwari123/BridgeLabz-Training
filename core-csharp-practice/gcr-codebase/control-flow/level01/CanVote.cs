using System;
class CanVote
{
    public static void Main(String []args)
    {
        int age = int.Parse(Console.ReadLine());
        if(age >= 18) Console.WriteLine("The person's age is "+ age +" can vote");
        else Console.WriteLine("The person's "+ age +" can not vote");
    }
}
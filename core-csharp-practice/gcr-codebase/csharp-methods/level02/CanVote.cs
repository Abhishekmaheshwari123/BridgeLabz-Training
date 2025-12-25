using System;
class CanVote
{
    public static void Main(String[]args)
    {
        for (int i = 0; i < 10; i++)
        {
            int age = int.Parse(Console.ReadLine());
            if(CanVote(Age))Console.WriteLine("Yes eligible for giving Vote");
            else Console.WriteLine("Not eligible for giving Vote");
        }
    }

    static Boolean CanVote(int age)
    {
        return age >= 18;
    }
}
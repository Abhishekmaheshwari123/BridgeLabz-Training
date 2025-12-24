using System;

class CanVote
{
    public static void Main(String[] args)
    {
        int age;
        for (int i = 1; i <= 10; i++){
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18){
                Console.WriteLine("The Person with age "+age+" can vote");
            }
            else{
                Console.WriteLine("The Person with age "+age+" cannot vote");
            }
        }
    }
}

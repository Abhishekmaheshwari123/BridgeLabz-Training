using System;
class BasicCalculator
{
    public static void Main(String []args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        //add
        float sum = a + b;

        // substraction
        float sub = a - b;

        // Product
        float pro = a * b;

        // division 
        float division = a / b;

        Console.WriteLine(" The addition, subtraction, multiplication and division value of 2 numbers "+a +" and "+b+" is "+sum+" ,"+sub+" ,"+pro+" ,"+division);

        // int add
    }
}
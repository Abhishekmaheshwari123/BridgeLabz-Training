using System;
class Calculator
{
    public static void Main(String[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        String op = Console.ReadLine();
        switch (op) {
            case "+" : 
                Console.WriteLine(a + b);
                break;
            case "-" :
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;
            case "/":
                if(b == 0)Console.WriteLine("Denominator can't be zero");
                else Console.WriteLine(a / b);
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
            
        }
    }
}
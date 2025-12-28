using System;

class Calculator
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];

        double result = 0;
        bool valid = true;

        if (op == '+')
            result = a + b;
        else if (op == '-')
            result = a - b;
        else if (op == '*')
            result = a * b;
        else if (op == '/')
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                valid = false;
            }
            else
                result = a / b;
        }
        else
            valid = false;

        if (valid)
            Console.WriteLine("Result: " + result);
    }
}

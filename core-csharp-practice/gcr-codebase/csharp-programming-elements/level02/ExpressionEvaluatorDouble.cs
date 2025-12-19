using System;

class ExpressionEvaluatorDouble
{
    public static void Main(String[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double exp1 = a + (b * c);
        double exp2 = (a * b) + c;
        double exp3 = a + (b / c);
        double exp4 = (a % b) + c;

        Console.WriteLine("The results of Double Operations are " +exp1 + ", " + exp2 + ", " + exp3 + ", " + exp4);
    }
}

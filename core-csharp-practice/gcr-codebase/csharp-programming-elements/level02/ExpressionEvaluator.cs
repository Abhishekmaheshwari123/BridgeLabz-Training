using System;
class ExpressionEvaluator
{
    public static void Main(String []args)
    {
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());
        int c1 = Convert.ToInt32(Console.ReadLine());

        int exp1 = a1 + (b1*c1);
        int exp2 = (a1 * b1)  + c1;
        int exp3 = a1 + (b1 / c1);
        int exp4 = (a1%b1) + c1;
        Console.WriteLine("The results of Int Operations are "+exp1+", "+exp2+", "+exp3+", "+exp4);
    }
}
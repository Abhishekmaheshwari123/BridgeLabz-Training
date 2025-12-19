using System;
class DataTypes
{
    public static void Main(String []args)
    {
        //implicitly type conversion
        int IntVar = 100;
        double DoubleVar = IntVar;
        Console.WriteLine(DoubleVar);
        //explicitly type conversion
        double DoubleVar2 = 9.78;
        int ExplicitIntVar = (int)DoubleVar2;
        Console.WriteLine(ExplicitIntVar);
    }
}
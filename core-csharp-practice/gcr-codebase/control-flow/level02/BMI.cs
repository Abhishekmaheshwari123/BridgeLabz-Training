using System;
class BMI
{
    public static void Main(String[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double Bmi = weight / (height * height);

        if(Bmi <= 18.4)Console.WriteLine("Under weight");
        else if(Bmi <= 24.9) Console.WriteLine("Normal");
        else if(Bmi <= 39.9) Console.WriteLine("Overweight");
        else Console.WriteLine("Obese");
    }
}
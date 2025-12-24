using System;

class BMI
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] height = new double[n];
        double[] weight = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for(int i = 0; i < n; i++)
        {
            height[i] = double.Parse(Console.ReadLine());            
            weight[i] = double.Parse(Console.ReadLine());
        }    
        for (int i = 0; i < n; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);
            if(bmi[i] < 18.5)
                status[i] = "Underweight";
            else if(bmi[i] < 25)
                status[i] = "Normal";
            else if(bmi[i] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Person "+ (i + 1));
            Console.WriteLine("Height : "+height[i]+"m");
            Console.WriteLine("Weight : "+weight[i]+"kg");
            Console.WriteLine("BMI    : "+bmi[i]+":0.00");
            Console.WriteLine("Status : "+status[i]);
        }
    }
}

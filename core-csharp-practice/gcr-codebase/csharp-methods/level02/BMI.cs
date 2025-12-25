using System;

class BMIProgram
{
    public static void Main(string[] args)
    {
        double[,] data = new double[10, 3];
        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = double.Parse(Console.ReadLine());
            data[i, 1] = double.Parse(Console.ReadLine());
        }
        CalculateBMI(data);
        string[] status = GetBMIStatus(data);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((i + 1) + "\t" +data[i, 0] + "\t" +data[i, 1] + "\t" +data[i, 2].ToString("0.00") + "\t" +status[i]);
        }
    }

    static void CalculateBMI(double[,] arr)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = arr[i, 0];
            double heightCm = arr[i, 1];

            double heightM = heightCm / 100.0;

            double bmi = weight / (heightM * heightM);

            arr[i, 2] = bmi;
        }
    }

    static string[] GetBMIStatus(double[,] arr)
    {
        string[] result = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = arr[i, 2];

            if (bmi < 18.5)
                result[i] = "Underweight";
            else if (bmi < 25)
                result[i] = "Normal";
            else if (bmi < 30)
                result[i] = "Overweight";
            else
                result[i] = "Obese";
        }

        return result;
    }
}

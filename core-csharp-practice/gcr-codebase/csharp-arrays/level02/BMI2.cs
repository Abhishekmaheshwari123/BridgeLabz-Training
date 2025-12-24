using System;

class BMI2
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        // personData[i][0] -> height
        // personData[i][1] -> weight
        // personData[i][2] -> BMI
        double[][] personData = new double[n][];
        string[] weightStatus = new string[n];
        for(int i = 0; i < n; i++)
            personData[i] = new double[3];

        for(int i = 0; i < n; i++)
        {
            while (true)
            {
                double h = double.Parse(Console.ReadLine());
                if (h > 0)
                {
                    personData[i][0] = h;
                    break;
                }

                Console.WriteLine("Enter a valid Height");
            }

            while (true)
            {
                double w = double.Parse(Console.ReadLine());

                if (w > 0)
                {
                    personData[i][1] = w;
                    break;
                }

                Console.WriteLine("Enter a valid weight");
            }
        }
        for (int i = 0; i < n; i++)
        {
            double height = personData[i][0];
            double weight = personData[i][1];

            double bmi = weight / (height * height);
            personData[i][2] = bmi;

            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi < 25)
                weightStatus[i] = "Normal";
            else if (bmi < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            Console.WriteLine("Height : " + personData[i][0] + " m");
            Console.WriteLine("Weight : " + personData[i][1] + " kg");
            Console.WriteLine("BMI    : " + personData[i][2].ToString("0.00"));
            Console.WriteLine("Status : " + weightStatus[i]);
        }

    }
}

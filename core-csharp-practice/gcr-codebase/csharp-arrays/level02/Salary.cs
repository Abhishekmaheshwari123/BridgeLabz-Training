using System;
class Salary
{
    public static void Main(String[]args)
    {
        double[,] arr = new double[10,5];

        // 0th index = Salary;
        // 1st index = year;
        // 2nd index = Bouns;
        // 3rd index = oldSalary;
        // 4th index = newSalary;

        for(int i = 0; i < 10; i++)
        {
            double salary = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            arr[i,0] = salary;
            arr[i,1] = year;
            double bonus = 0.0;
            if(year < 5) bonus = (salary * 2.0)/100.0;
            else bonus = (salary * 5.0) / 100.0;
            arr[i,2] = bonus;
            double oldSalary = salary * year;

            double newSalary = oldSalary + bonus;
            arr[i,3] = oldSalary;
            arr[i,4] = newSalary;
        }

        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("bonus ="+ arr[i,2]+ "   oldSalary = "+ arr[i,3]+"   newSalary = "+arr[i,4]);
        }
    }
}
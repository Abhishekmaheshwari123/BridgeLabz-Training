using System;

class ZaraBonus
{
    static void Main(string[] args)
    {
        int employeeCount = 10;
        double[,] employees = GenerateSalaryAndService(employeeCount);

        Console.WriteLine("Old Salary and Years of Service:");
        Console.WriteLine("Emp\tSalary\t\tYears");
        for (int i = 0; i < employeeCount; i++)
            Console.WriteLine("{0}\t{1}\t\t{2}", i + 1, (int)employees[i, 0], (int)employees[i, 1]);

        double[,] updated = CalculateBonus(employees);

        Console.WriteLine("\nUpdated Salary and Bonus:");
        Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("{0}\t{1}\t\t{2}\t{3:F2}\t\t{4:F2}",
                i + 1, (int)employees[i, 0], (int)employees[i, 1],
                updated[i, 1], updated[i, 0]);
        }        
        double oldSum, newSum, totalBonus;
        CalculateTotals(employees, updated, out oldSum, out newSum, out totalBonus);

        Console.WriteLine("\nTotals:");
        Console.WriteLine("Sum of Old Salary: " + oldSum);
        Console.WriteLine("Sum of New Salary: " + newSum);
        Console.WriteLine("Total Bonus Amount: " + totalBonus);
    }    
    static double[,] GenerateSalaryAndService(int count)
    {
        double[,] arr = new double[count, 2];
        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            arr[i, 0] = rand.Next(10000, 100000); 
            arr[i, 1] = rand.Next(1, 11);         
        }

        return arr;
    }
    static double[,] CalculateBonus(double[,] employees)
    {
        int count = employees.GetLength(0);
        double[,] updated = new double[count, 2];

        for (int i = 0; i < count; i++)
        {
            double oldSalary = employees[i, 0];
            double years = employees[i, 1];
            double bonusPercent = years > 5 ? 0.05 : 0.02;
            double bonus = oldSalary * bonusPercent;
            double newSalary = oldSalary + bonus;

            updated[i, 0] = newSalary;
            updated[i, 1] = bonus;
        }

        return updated;
    }
    static void CalculateTotals(double[,] oldArr, double[,] updatedArr, out double oldSum, out double newSum, out double totalBonus)
    {
        int count = oldArr.GetLength(0);
        oldSum = 0;
        newSum = 0;
        totalBonus = 0;

        for (int i = 0; i < count; i++)
        {
            oldSum += oldArr[i, 0];
            newSum += updatedArr[i, 0];
            totalBonus += updatedArr[i, 1];
        }
    }
}

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "employees.csv";

        string[] records =
        {
            "ID,Name,Department,Salary",
            "1,Ravi,IT,60000",
            "2,Pooja,HR,45000",
            "3,Neha,Finance,55000",
            "4,Aman,IT,70000",
            "5,Suresh,Sales,50000"
        };

        File.WriteAllLines(path, records);

        Console.WriteLine("Employee CSV file created successfully!");
    }
}

using System;

class Employee
{
    public static string CompanyName = "Microsoft";
    public static int TotalEmployees = 0;

    public string Name;
    public readonly int Id;
    public string Designation;

    public Employee(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;

        TotalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + TotalEmployees);
    }

    public void ShowDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Designation: " + Designation);
        }
    }

    static void Main(string[] args)
    {
        Employee e1 = new Employee("Abhi", 101, "Developer");
        Employee e2 = new Employee("Riya", 102, "Tester");

        e1.ShowDetails();
        Console.WriteLine();
        e2.ShowDetails();

        Console.WriteLine();
        Employee.DisplayTotalEmployees();
    }
}

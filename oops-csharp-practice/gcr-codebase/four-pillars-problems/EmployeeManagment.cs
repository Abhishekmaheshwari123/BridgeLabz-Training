using System;
using System.Collections.Generic;

abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public Employee(int id, string n, double salary)
    {
        EmployeeId = id;
        Name = n;
        BaseSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + EmployeeId + " Name: " + Name + " Base Salary: " + BaseSalary);
    }
}

interface IDepartment
{
    void AssignDepartment(string dept);
    string GetDepartmentDetails();
}

class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public FullTimeEmployee(int id, string n, double s) : base(id, n, s) { }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int hoursWorked;
    private double hourlyRate;

    public PartTimeEmployee(int id, string n, double rate, int hours) : base(id, n, 0)
    {
        hourlyRate = rate;
        hoursWorked = hours;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new FullTimeEmployee(1, "A", 50000));
        employees.Add(new PartTimeEmployee(2, "B", 500, 40));

        foreach (Employee e in employees)
        {
            e.DisplayDetails();
            Console.WriteLine("Salary: " + e.CalculateSalary());
        }
    }
}

using System;

class Employee
{
    public int EmployeeID;
    protected string Department;
    private double Salary;

    public Employee(int id, string dept, double salary)
    {
        EmployeeID = id;
        Department = dept;
        Salary = salary;
    }

    public void UpdateSalary(double newSalary)
    {
        Salary = newSalary;
    }

    public double GetSalary()
    {
        return Salary;
    }
}

class Manager : Employee
{
    public string TeamName;

    public Manager(int id, string dept, double salary, string team)
        : base(id, dept, salary)
    {
        TeamName = team;
    }

    public void ShowEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeID);  // public ✔
        Console.WriteLine("Department: " + Department);   // protected ✔
        Console.WriteLine("Team: " + TeamName);
        Console.WriteLine("-----------------------");
    }

    static void Main(string[] args)
    {
        Manager m = new Manager(201, "IT", 60000, "Backend Team");

        m.ShowEmployeeDetails();

        m.UpdateSalary(70000);
        Console.WriteLine("Updated Salary: " + m.GetSalary());
    }
}

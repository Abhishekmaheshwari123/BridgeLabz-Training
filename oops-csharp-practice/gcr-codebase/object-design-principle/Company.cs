using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
}

class Department
{
    public string DeptName { get; set; }
    public List<Employee> Employees { get; set; }

    public Department()
    {
        Employees = new List<Employee>();
    }
}

class Company
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }

    public Company()
    {
        Departments = new List<Department>();
    }
}

class Program
{
    static void Main()
    {
        Company c = new Company { Name = "XYZ" };
        Department d = new Department { DeptName = "IT" };
        d.Employees.Add(new Employee { Name = "A" });
        c.Departments.Add(d);
        c = null;
    }
}

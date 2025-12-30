using System;
class Employee
{
    public static void Main(String[] args)
    {
        Person p = new Person("Abhi","CEA99",90000.0);

        p.display();
    }
}


class Person
{
    string EmployeeName;
    string EmployeeId;
    double Salary;
    public Person(string employeeName, string employeeId, double salary)
    {
        EmployeeName = employeeName;
        EmployeeId = employeeId;
        Salary = salary;
    }

    public void display()
    {
        Console.WriteLine("Name : "+EmployeeName+",  Id : "+EmployeeId+",  Salary "+Salary);
    }
}
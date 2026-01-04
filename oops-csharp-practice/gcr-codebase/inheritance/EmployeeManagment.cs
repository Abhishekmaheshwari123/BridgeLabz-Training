using System;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public virtual void DisplayDetails()
    {
        Console.WriteLine(Name + " " + Id + " " + Salary);
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine(Name + " " + Id + " " + Salary + " " + TeamSize);
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine(Name + " " + Id + " " + Salary + " " + ProgrammingLanguage);
    }
}

class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine(Name + " " + Id + " " + Salary + " " + InternshipDuration);
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.Name = "A";
        m.Id = 1;
        m.Salary = 50000;
        m.TeamSize = 5;
        m.DisplayDetails();

        Developer d = new Developer();
        d.Name = "B";
        d.Id = 2;
        d.Salary = 40000;
        d.ProgrammingLanguage = "C#";
        d.DisplayDetails();

        Intern i = new Intern();
        i.Name = "C";
        i.Id = 3;
        i.Salary = 10000;
        i.InternshipDuration = "6 Months";
        i.DisplayDetails();
    }
}

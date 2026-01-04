using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; set; }
}

class DepartmentU
{
    public string Name { get; set; }
}

class University
{
    public string Name { get; set; }
    public List<DepartmentU> Departments { get; set; }
    public List<Faculty> Faculties { get; set; }

    public University()
    {
        Departments = new List<DepartmentU>();
        Faculties = new List<Faculty>();
    }
}

class Program
{
    static void Main()
    {
        University u = new University { Name = "ABC" };
        u.Departments.Add(new DepartmentU { Name = "CS" });
        Faculty f = new Faculty { Name = "Dr A" };
        u.Faculties.Add(f);
        u = null;
    }
}

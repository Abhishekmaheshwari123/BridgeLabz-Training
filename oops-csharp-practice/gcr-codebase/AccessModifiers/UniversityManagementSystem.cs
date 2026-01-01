using System;

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    public void SetCGPA(double newCgpa)
    {
        CGPA = newCgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
}

class PostgraduateStudent : Student
{
    public string ResearchArea;

    public PostgraduateStudent(int roll, string name, double cgpa, string researchArea)
        : base(roll, name, cgpa)
    {
        ResearchArea = researchArea;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Roll: " + RollNumber);
        Console.WriteLine("Name: " + Name);   // allowed (protected)
        Console.WriteLine("Research Area: " + ResearchArea);
        Console.WriteLine("-----------------------");
    }

    static void Main(string[] args)
    {
        PostgraduateStudent ps = new PostgraduateStudent(101, "Abhi", 8.5, "AI");

        ps.DisplayDetails();

        ps.SetCGPA(9.1);
        Console.WriteLine("Updated CGPA: " + ps.GetCGPA());
    }
}

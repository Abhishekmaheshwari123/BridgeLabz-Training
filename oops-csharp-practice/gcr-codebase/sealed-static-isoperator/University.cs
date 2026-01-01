using System;

class Student
{
    public static string UniversityName = "Delhi University";
    public static int TotalStudents = 0;

    public string Name;
    public readonly int RollNumber;
    public string Grade;

    public Student(string name, int roll, string grade)
    {
        this.Name = name;
        this.RollNumber = roll;
        this.Grade = grade;

        TotalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + TotalStudents);
    }

    public void ShowStudent()
    {
        if (this is Student)
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
    }

    static void Main(string[] args)
    {
        Student s1 = new Student("Abhi", 1, "A");
        Student s2 = new Student("Riya", 2, "B");

        s1.ShowStudent();
        Console.WriteLine();
        s2.ShowStudent();

        Console.WriteLine();
        Student.DisplayTotalStudents();
    }
}

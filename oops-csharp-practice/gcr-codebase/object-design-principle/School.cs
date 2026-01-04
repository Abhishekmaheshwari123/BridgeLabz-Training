using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public Course()
    {
        Students = new List<Student>();
    }
}

class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student()
    {
        Courses = new List<Course>();
    }

    public void Enroll(Course c)
    {
        Courses.Add(c);
        c.Students.Add(this);
    }
}

class School
{
    public List<Student> Students { get; set; }

    public School()
    {
        Students = new List<Student>();
    }
}

class Program
{
    static void Main()
    {
        School s = new School();
        Student st = new Student { Name = "John" };
        Course c = new Course { Name = "Math" };
        st.Enroll(c);
        s.Students.Add(st);
    }
}

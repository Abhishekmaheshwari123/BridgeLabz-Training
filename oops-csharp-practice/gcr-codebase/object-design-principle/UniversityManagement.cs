using System;
using System.Collections.Generic;

class CourseM
{
    public string Title { get; set; }
    public Professor Teacher { get; set; }
    public List<StudentM> Students { get; set; }

    public CourseM()
    {
        Students = new List<StudentM>();
    }
}

class StudentM
{
    public string Name { get; set; }

    public void EnrollCourse(CourseM c)
    {
        c.Students.Add(this);
    }
}

class Professor
{
    public string Name { get; set; }

    public void AssignProfessor(CourseM c)
    {
        c.Teacher = this;
    }
}

class Program
{
    static void Main()
    {
        CourseM c = new CourseM { Title = "Math" };
        StudentM s = new StudentM { Name = "John" };
        Professor p = new Professor { Name = "Dr X" };
        s.EnrollCourse(c);
        p.AssignProfessor(c);
    }
}

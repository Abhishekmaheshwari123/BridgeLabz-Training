using System;

class Course
{
    public string CourseName;
    public int Duration;
    public double Fee;

    // class variable
    public static string InstituteName = "Skill Academy";

    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course: " + CourseName +
                          ", Duration: " + Duration +
                          " months, Fee: " + Fee +
                          ", Institute: " + InstituteName);
    }

    public static void UpdateInstituteName(string newName)
    {
        InstituteName = newName;
    }

    static void Main(string[] args)
    {
        Course c1 = new Course("Java", 3, 8000);
        Course c2 = new Course("C#", 4, 9000);

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        Console.WriteLine("\nUpdating institute...\n");
        Course.UpdateInstituteName("Tech Learning Center");

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}

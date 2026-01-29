using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int ID;
    public string Name;
    public int Age;
    public int Marks;
}

class Program
{
    static void Main()
    {
        string path = "students.csv";

        List<Student> students = new List<Student>();

        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            students.Add(new Student()
            {
                ID = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            });
        }

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} ({s.Age}) scored {s.Marks}");
        }
    }
}

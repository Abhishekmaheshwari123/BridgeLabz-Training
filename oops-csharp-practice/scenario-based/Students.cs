// class student id name age marks
// class subject class different subjects

// add a student , sort(name), sort(marks);



using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

public class Student
{

    int TotalStudents;
    string []StudentId;
    string []Name;
    int []age;
    int[,] Marks;

    public Student(int TotalStudents,string []StudentId,string []Name,int []age,int[,] Marks)
    {
        TotalStudents = 0;
        StudentId = new string[5];
        Name=new string[5];
        age = new int[5];
        Marks = new int[5,3];
    }



    static void SortByName(string[]Name)
    {
        Array.Sort(Name);
    }

    static void SortByMarks(int[][] Marks)
    {
        Array.Sort(Marks, (a, b) => a[0].CompareTo(b[0]));
    }

    static void Rebuild()
    {
        int prevLength = StudentId.GetLength(0);
        int[] oldStudentId = StudentId;
        int[] oldName = name;
        int[] oldAge = age;
        int[,] oldMarks = Marks;

        StudentId = new int[2 * oldStudentId.Length];
        name = new int[2 * oldName.Length];
        age = new int[2 * oldAge.Length];
        Marks = new int[2 * oldMarks.GetLength(0), oldMarks.GetLength(1)];

        for (int i = 0; i < oldStudentId.Length; i++)
        {
            StudentId[i] = oldStudentId[i];
        }
        for (int i = 0; i < oldName.Length; i++)
        {
            name[i] = oldName[i];
        }
        for (int i = 0; i < oldAge.Length; i++)
        {
            age[i] = oldAge[i];
        }

        for (int i = 0; i < oldMarks.GetLength(0); i++)
        {
            for (int j = 0; j < oldMarks.GetLength(1); j++)
            {
                Marks[i, j] = oldMarks[i, j];
            }
        }

    }

    static void AddStudent()
    {
        TotalStudents++;
        if(TotalStudents == Marks.GetLength(0))
        {
            Rebuild(Marks);
        }

        Console.WriteLine("Enter the StudentId");
        Student[TotalStudents] = Console.ReadLine();

        Console.WriteLine("Enter the Student Name");
        Name[TotalStudents] = Console.ReadLine();

        Console.WriteLine("Enter the Student age");
        age[TotalStudents] = Console.ReadLine();
        int IndividualSum = 0;
        for(int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Enter the "+(i+1)+" subject Marks");
            Marks[TotalStudents , i] = int.Parse(Console.ReadLine());
            IndividualSum += Marks[TotalStudents , i];
        }

        Marks[TotalStudents , 3] = IndividualSum;
    }
    
}

public class subject
{
    public static void Main(String[] args)
    {
        Student st = new Student();        
        Menu(st);
    }

    static void Menu(Student st)
    {
        Console.WriteLine("------menu-----");
        Console.WriteLine("Enter 1 for add Students");
        Console.WriteLine("Enter 2 for sort Students by name");
        Console.WriteLine("Enter 3 for sort Students by marks");
        int Press = int.Parse(Console.ReadLine());
        if(Press == 1) {
            st.AddStudent();
            Menu(st);
        }
        else if(Press == 2)
        {
            st.SortByName();
            Menu(st);
        }
        else if(Press == 3)
        {
            st.SortByMarks();
            Menu(st);
        }        
    }
}
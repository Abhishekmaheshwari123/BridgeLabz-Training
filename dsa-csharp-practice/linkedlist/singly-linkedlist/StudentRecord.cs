using System;

class StudentNode
{
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, string grade)
    {
        RollNo = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentList
{
    public StudentNode head;

    public void AddAtEnd(int roll, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void DeleteByRoll(int roll)
    {
        if (head == null) return;

        if (head.RollNo == roll)
        {
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public void Search(int roll)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                Console.WriteLine("Found: " + temp.Name + " Grade: " + temp.Grade);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    public void UpdateGrade(int roll, string newGrade)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade Updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    public void Display()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(
                "Roll: " + temp.RollNo +
                " Name: " + temp.Name +
                " Age: " + temp.Age +
                " Grade: " + temp.Grade
            );
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentList list = new StudentList();

        list.AddAtEnd(1, "Rahul", 20, "A");
        list.AddAtEnd(2, "Anita", 21, "B");
        list.AddAtEnd(3, "Vikas", 22, "C");

        Console.WriteLine("All Students:");
        list.Display();

        Console.WriteLine("\nSearch Roll 2:");
        list.Search(2);

        Console.WriteLine("\nUpdate Grade Roll 3:");
        list.UpdateGrade(3, "A+");

        Console.WriteLine("\nAfter Update:");
        list.Display();

        Console.WriteLine("\nDelete Roll 1:");
        list.DeleteByRoll(1);

        Console.WriteLine("\nFinal List:");
        list.Display();
    }
}


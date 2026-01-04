using System;

class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(Title + " " + PublicationYear);
    }
}

class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine(Title + " " + PublicationYear + " " + Name + " " + Bio);
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author();
        a.Title = "ABC";
        a.PublicationYear = 2020;
        a.Name = "XYZ";
        a.Bio = "Writer";
        a.DisplayInfo();
    }
}

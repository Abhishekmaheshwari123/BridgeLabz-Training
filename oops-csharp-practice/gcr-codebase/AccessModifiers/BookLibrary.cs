using System;

class Book
{
    public string ISBN;
    protected string Title;
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }
}

class EBook : Book
{
    public double FileSize;

    public EBook(string isbn, string title, string author, double fileSize)
        : base(isbn, title, author)
    {
        FileSize = fileSize;
    }

    public void ShowBookInfo()
    {
        Console.WriteLine("ISBN: " + ISBN);     // public ✔
        Console.WriteLine("Title: " + Title);   // protected ✔
        Console.WriteLine("File Size: " + FileSize + " MB");
        Console.WriteLine("-----------------------");
    }

    static void Main(string[] args)
    {
        EBook eb = new EBook("978-12345", "C# Guide", "John", 2.5);

        eb.ShowBookInfo();

        eb.SetAuthor("Michael");
        Console.WriteLine("Updated Author: " + eb.GetAuthor());
    }
}

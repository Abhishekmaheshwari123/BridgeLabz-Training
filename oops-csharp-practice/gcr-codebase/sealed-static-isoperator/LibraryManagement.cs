using System;

class Book
{
    public static string LibraryName = "City Library";

    public string Title;
    public string Author;
    public readonly string ISBN;

    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + LibraryName);
    }

    public void ShowDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }

    static void Main(string[] args)
    {
        Book.DisplayLibraryName();

        Book b1 = new Book("C# Basics", "John", "ISBN001");
        Console.WriteLine();
        b1.ShowDetails();
    }
}

using System;

class LibraryBook
{
    public string Title;
    public string Author;
    public double Price;
    public bool IsAvailable;

    public LibraryBook(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else
        {
            Console.WriteLine("Book is not available.");
        }
    }

    static void Main(string[] args)
    {
        LibraryBook b = new LibraryBook("C# Basics", "John", 300);

        b.BorrowBook();   // first time
        b.BorrowBook();   // second time (not available)
    }
}

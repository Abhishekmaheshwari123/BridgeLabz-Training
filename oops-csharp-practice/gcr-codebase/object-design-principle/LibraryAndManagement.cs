using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book { Title = "A", Author = "X" };
        Book b2 = new Book { Title = "B", Author = "Y" };

        Library l1 = new Library();
        Library l2 = new Library();

        l1.Books.Add(b1);
        l2.Books.Add(b1);
        l2.Books.Add(b2);
    }
}

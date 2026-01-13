using System;
class Book : IBook
{
    string Title;
    string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }    
}
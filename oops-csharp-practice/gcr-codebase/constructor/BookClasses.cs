using System;
class BookClasses
{
    public string Title;
    public string Author;
    public double Price;

    public BookClasses()
    {
        Title = "Atoms";
        Author = "Abhi";
        Price = 0;
    }

    public BookClasses(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}

class BookClass
{
    static void Main(string[] args)
    {
        BookClasses b1 = new BookClasses();
        Console.WriteLine(b1.Title + " - " + b1.Author + " - " + b1.Price);

        BookClasses b2 = new BookClasses("Java", "James Gosling", 450);
        Console.WriteLine(b2.Title + " - " + b2.Author + " - " + b2.Price);
    }
}

using System;

class BookNode
{
    public int Id;
    public string Title, Author;
    public bool Available;
    public BookNode prev, next;

    public BookNode(int i, string t, string a, bool av)
    {
        Id = i;
        Title = t;
        Author = a;
        Available = av;
    }
}

class Library
{
    BookNode head;

    public void AddBook(int i, string t, string a, bool av)
    {
        BookNode b = new BookNode(i, t, a, av);
        if (head != null)
        {
            b.next = head;
            head.prev = b;
        }
        head = b;
    }

    public void Display()
    {
        BookNode t = head;
        while (t != null)
        {
            Console.WriteLine(t.Title + " " + t.Author);
            t = t.next;
        }
    }
}

class Program
{
    static void Main()
    {
        Library l = new Library();
        l.AddBook(1, "CSharp", "MS", true);
        l.AddBook(2, "DSA", "CLRS", true);
        l.Display();
    }
}

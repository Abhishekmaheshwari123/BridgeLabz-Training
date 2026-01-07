using System;
using System.Collections.Generic;

abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;
    private string borrower;

    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    protected string Borrower
    {
        get { return borrower; }
        set { borrower = value; }
    }

    public LibraryItem(int id, string t, string a)
    {
        ItemId = id;
        Title = t;
        Author = a;
    }

    public abstract int GetLoanDuration();

    public string GetItemDetails()
    {
        return "ID: " + ItemId + " Title: " + Title + " Author: " + Author;
    }
}

interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

class Book : LibraryItem, IReservable
{
    private bool reserved;

    public Book(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem(string borrowerName)
    {
        reserved = true;
        Borrower = borrowerName;
    }

    public bool CheckAvailability()
    {
        return !reserved;
    }
}

class Magazine : LibraryItem, IReservable
{
    private bool reserved;

    public Magazine(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem(string borrowerName)
    {
        reserved = true;
        Borrower = borrowerName;
    }

    public bool CheckAvailability()
    {
        return !reserved;
    }
}

class DVD : LibraryItem, IReservable
{
    private bool reserved;

    public DVD(int id, string t, string a) : base(id, t, a) { }

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem(string borrowerName)
    {
        reserved = true;
        Borrower = borrowerName;
    }

    public bool CheckAvailability()
    {
        return !reserved;
    }
}

class Program5
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>();
        items.Add(new Book(1, "Book A", "Author A"));
        items.Add(new Magazine(2, "Mag B", "Author B"));
        items.Add(new DVD(3, "Movie C", "Director C"));

        foreach (LibraryItem item in items)
        {
            Console.WriteLine(item.GetItemDetails());
            Console.WriteLine("Loan Days: " + item.GetLoanDuration());
        }
    }
}

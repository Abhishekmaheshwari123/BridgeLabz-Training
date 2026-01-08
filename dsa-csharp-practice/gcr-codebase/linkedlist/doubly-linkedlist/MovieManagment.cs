using System;

class MovieNode
{
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode prev, next;

    public MovieNode(string t, string d, int y, double r)
    {
        Title = t;
        Director = d;
        Year = y;
        Rating = r;
        prev = next = null;
    }
}

class MovieList
{
    MovieNode head;

    public void AddAtEnd(string t, string d, int y, double r)
    {
        MovieNode n = new MovieNode(t, d, y, r);
        if (head == null)
        {
            head = n;
            return;
        }
        MovieNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = n;
        n.prev = temp;
    }

    public void RemoveByTitle(string title)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                if (temp.prev != null)
                    temp.prev.next = temp.next;
                else
                    head = temp.next;

                if (temp.next != null)
                    temp.next.prev = temp.prev;
                return;
            }
            temp = temp.next;
        }
    }

    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " " + temp.Director + " " + temp.Rating);
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        MovieNode temp = head;
        if (temp == null) return;

        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            Console.WriteLine(temp.Title + " " + temp.Rating);
            temp = temp.prev;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList list = new MovieList();
        list.AddAtEnd("Inception", "Nolan", 2010, 9.0);
        list.AddAtEnd("Interstellar", "Nolan", 2014, 8.8);

        list.DisplayForward();
        Console.WriteLine("Reverse:");
        list.DisplayReverse();
    }
}

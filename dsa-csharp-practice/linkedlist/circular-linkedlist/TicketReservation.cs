using System;

class Ticket
{
    public int Id;
    public string Customer, Movie;
    public Ticket next;

    public Ticket(int i, string c, string m)
    {
        Id = i;
        Customer = c;
        Movie = m;
    }
}

class TicketList
{
    Ticket head;

    public void Add(int i, string c, string m)
    {
        Ticket t = new Ticket(i, c, m);
        if (head == null)
        {
            head = t;
            t.next = head;
            return;
        }
        Ticket temp = head;
        while (temp.next != head)
            temp = temp.next;

        temp.next = t;
        t.next = head;
    }

    public void Display()
    {
        Ticket t = head;
        do
        {
            Console.WriteLine(t.Id + " " + t.Customer);
            t = t.next;
        } while (t != head);
    }
}

class Program
{
    static void Main()
    {
        TicketList list = new TicketList();
        list.Add(1, "Ram", "Avatar");
        list.Add(2, "Shyam", "Titanic");
        list.Display();
    }
}

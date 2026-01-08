using System;

class Process
{
    public int Id, Burst;
    public Process next;

    public Process(int i, int b)
    {
        Id = i;
        Burst = b;
    }
}

class Scheduler
{
    Process head;

    public void Add(int i, int b)
    {
        Process p = new Process(i, b);
        if (head == null)
        {
            head = p;
            p.next = head;
            return;
        }
        Process t = head;
        while (t.next != head)
            t = t.next;
        t.next = p;
        p.next = head;
    }

    public void Display()
    {
        Process t = head;
        do
        {
            Console.WriteLine("P" + t.Id + " " + t.Burst);
            t = t.next;
        } while (t != head);
    }
}

class Program
{
    static void Main()
    {
        Scheduler s = new Scheduler();
        s.Add(1, 5);
        s.Add(2, 3);
        s.Display();
    }
}

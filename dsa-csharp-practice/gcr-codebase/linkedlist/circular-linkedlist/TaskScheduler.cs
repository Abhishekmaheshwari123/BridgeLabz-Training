using System;

class TaskNode
{
    public int Id, Priority;
    public string Name, DueDate;
    public TaskNode next;

    public TaskNode(int i, string n, int p, string d)
    {
        Id = i;
        Name = n;
        Priority = p;
        DueDate = d;
        next = null;
    }
}

class TaskList
{
    TaskNode head;

    public void AddTask(int i, string n, int p, string d)
    {
        TaskNode node = new TaskNode(i, n, p, d);
        if (head == null)
        {
            head = node;
            node.next = head;
            return;
        }
        TaskNode temp = head;
        while (temp.next != head)
            temp = temp.next;

        temp.next = node;
        node.next = head;
    }

    public void Display()
    {
        if (head == null) return;
        TaskNode temp = head;
        do
        {
            Console.WriteLine(temp.Id + " " + temp.Name);
            temp = temp.next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        TaskList t = new TaskList();
        t.AddTask(1, "Task1", 1, "10-01");
        t.AddTask(2, "Task2", 2, "12-01");
        t.Display();
    }
}

using System;
using System.Collections.Generic;

class User
{
    public int Id;
    public string Name;
    public List<int> Friends = new List<int>();
    public User next;

    public User(int i, string n)
    {
        Id = i;
        Name = n;
    }
}

class Network
{
    User head;

    public void AddUser(int i, string n)
    {
        User u = new User(i, n);
        u.next = head;
        head = u;
    }

    public void Display()
    {
        User t = head;
        while (t != null)
        {
            Console.WriteLine(t.Name + " Friends: " + t.Friends.Count);
            t = t.next;
        }
    }
}

class Program
{
    static void Main()
    {
        Network n = new Network();
        n.AddUser(1, "A");
        n.AddUser(2, "B");
        n.Display();
    }
}

using System;

class State
{
    public string Text;
    public State prev, next;

    public State(string t)
    {
        Text = t;
    }
}

class Editor
{
    State current;

    public void Add(string t)
    {
        State s = new State(t);
        if (current != null)
        {
            current.next = s;
            s.prev = current;
        }
        current = s;
    }

    public void Undo()
    {
        if (current != null && current.prev != null)
            current = current.prev;
    }

    public void Show()
    {
        if (current != null)
            Console.WriteLine(current.Text);
    }
}

class Program
{
    static void Main()
    {
        Editor e = new Editor();
        e.Add("Hello");
        e.Add("Hello World");
        e.Undo();
        e.Show();
    }
}

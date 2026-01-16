using System;
using System.Collections.Generic;

class BrowserUtility : IBrowser
{
    Stack<Tab> history = new Stack<Tab>();
     Tab head = new Tab("head");
    Tab CurrentTab ;
    Tab Tail ;
    public BrowserUtility()
    {
        CurrentTab = head;
        Tail = head;
    }
    // ---------------------ADD TAB---------------------
    public void AddTab()
    {
        Console.WriteLine("Enter the Data in Tab");
        string data = Console.ReadLine();
        Tab  newTab = new Tab(data);

        Tail.next = null;
        Tail.next = newTab;
        newTab.prev = Tail;
        Tail = Tail.next;


        CurrentTab = Tail;
    }

// ---------------------CLOSE TAB---------------------
    public void CloseTab()
    {
        if(CurrentTab == head)
        {
            Console.WriteLine("There is no tab to close");
            return ;
        }
        history.Push(CurrentTab);
        Console.WriteLine("Closed Tab's data : "+CurrentTab.url);

        if(CurrentTab == Tail) Tail = Tail.prev;

        CurrentTab.prev.next = CurrentTab.next;

        if(CurrentTab.next != null)
        {
            CurrentTab.next.prev = CurrentTab.prev;
        }

        CurrentTab = CurrentTab.prev;
        Console.WriteLine("tab is Closed Successfully");

    }

// ---------------------Move Forward Tab---------------------
    public void MoveForwardTab()
    {
        if(CurrentTab == Tail)
        {
            Console.WriteLine("There is no tab to move forward");
            return ;
        }

        CurrentTab = CurrentTab.next;
        Console.WriteLine("Forwarded Tab's data : "+CurrentTab.url);
        Console.WriteLine("tab is Moved Forward Successfully");
    }
// ---------------------Move Backward Tab---------------------
    public void MoveBackwardTab()
    {
        if(CurrentTab == head)
        {
            Console.WriteLine("There is no tab to move backward");
            return ;
        }

        CurrentTab = CurrentTab.prev;
        Console.WriteLine("Backwarded Tab's data : "+CurrentTab.url);
        Console.WriteLine("tab is Moved Backward Successfully");
    }

// ---------------------Restore Last Closed Tab---------------------
    public void RestoreTab()
    {
        if(history.Count == 0)
        {
            Console.WriteLine("Nothing to Restore");
            return ;
        }
        Tab RestoredTab = history.Pop();

        RestoredTab.prev.next = RestoredTab;

        if(RestoredTab.next != null)
        {
            RestoredTab.next.prev = RestoredTab;
        }
        else Tail = RestoredTab;
        CurrentTab = RestoredTab;
        Console.WriteLine("Restored Tab's data : "+RestoredTab.url);
        Console.WriteLine("tab is restored Successfully");
    }


}
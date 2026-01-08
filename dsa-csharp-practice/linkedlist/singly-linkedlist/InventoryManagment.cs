using System;

class ItemNode
{
    public int Id, Qty;
    public string Name;
    public double Price;
    public ItemNode next;

    public ItemNode(int i, string n, int q, double p)
    {
        Id = i;
        Name = n;
        Qty = q;
        Price = p;
        next = null;
    }
}

class Inventory
{
    ItemNode head;

    public void AddItem(int i, string n, int q, double p)
    {
        ItemNode node = new ItemNode(i, n, q, p);
        node.next = head;
        head = node;
    }

    public void TotalValue()
    {
        double sum = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            sum += temp.Price * temp.Qty;
            temp = temp.next;
        }
        Console.WriteLine("Total Value: " + sum);
    }
}

class Program
{
    static void Main()
    {
        Inventory inv = new Inventory();
        inv.AddItem(1, "Pen", 10, 5);
        inv.AddItem(2, "Book", 3, 100);
        inv.TotalValue();
    }
}

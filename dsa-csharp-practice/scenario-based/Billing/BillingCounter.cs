using System;
using System.Collections.Generic;

class BillingCounter
{
    private Queue<Customer> queue;
    private Inventory inventory;

    public BillingCounter(Inventory inventory)
    {
        this.inventory = inventory;
        queue = new Queue<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
        queue.Enqueue(customer);
        Console.WriteLine(customer.Name + " added to billing queue.");
    }

    public void ProcessCustomer()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }

        Customer c = queue.Dequeue();
        int total = 0;

        foreach (string item in c.Items)
        {
            if (inventory.IsAvailable(item))
            {
                total += inventory.GetPrice(item);
                inventory.ReduceStock(item);
            }
            else
            {
                Console.WriteLine(item + " is out of stock.");
            }
        }

        Console.WriteLine("Customer: " + c.Name);
        Console.WriteLine("Total Bill: ₹" + total);
    }
}

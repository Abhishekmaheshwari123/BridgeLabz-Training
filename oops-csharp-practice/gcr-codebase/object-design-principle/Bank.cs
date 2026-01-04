using System;
using System.Collections.Generic;

class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank()
    {
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer c)
    {
        Customers.Add(c);
        c.Bank = this;
    }
}

class Customer
{
    public string Name { get; set; }
    public Bank Bank { get; set; }
    public double Balance { get; set; }

    public double ViewBalance()
    {
        return Balance;
    }
}

class Program
{
    static void Main()
    {
        Bank b = new Bank { Name = "ABC" };
        Customer c = new Customer { Name = "John", Balance = 5000 };
        b.OpenAccount(c);
        Console.WriteLine(c.ViewBalance());
    }
}

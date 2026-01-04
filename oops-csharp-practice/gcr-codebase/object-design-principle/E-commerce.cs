using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Order
{
    public List<Product> Products { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }
}

class CustomerE
{
    public string Name { get; set; }

    public Order PlaceOrder(List<Product> items)
    {
        Order o = new Order();
        foreach (Product p in items) o.Products.Add(p);
        return o;
    }
}

class Program
{
    static void Main()
    {
        CustomerE c = new CustomerE { Name = "A" };
        List<Product> list = new List<Product>();
        list.Add(new Product { Name = "P1", Price = 100 });
        Order o = c.PlaceOrder(list);
    }
}

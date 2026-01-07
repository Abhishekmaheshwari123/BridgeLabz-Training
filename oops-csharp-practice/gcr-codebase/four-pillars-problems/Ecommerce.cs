using System;
using System.Collections.Generic;

abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public Product(int id, string n, double p)
    {
        ProductId = id;
        Name = n;
        Price = p;
    }

    public abstract double CalculateDiscount();
}

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDiscount()
    {
        return Price * 0.1;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18 percent GST";
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDiscount()
    {
        return Price * 0.2;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return "5 percent GST";
    }
}

class Groceries : Product
{
    public Groceries(int id, string n, double p) : base(id, n, p) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

class Program2
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add(new Electronics(1, "Phone", 50000));
        products.Add(new Clothing(2, "Shirt", 2000));
        products.Add(new Groceries(3, "Rice", 1000));

        foreach (Product p in products)
        {
            double discount = p.CalculateDiscount();
            double tax = 0;

            ITaxable taxable = p as ITaxable;
            if (taxable != null)
            {
                tax = taxable.CalculateTax();
            }

            double finalPrice = p.Price + tax - discount;
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}

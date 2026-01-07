using System;
using System.Collections.Generic;

abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public FoodItem(string name, double price, int qty)
    {
        ItemName = name;
        Price = price;
        Quantity = qty;
    }

    public abstract double CalculateTotalPrice();

    public string GetItemDetails()
    {
        return "Item: " + ItemName + " Price: " + Price + " Qty: " + Quantity;
    }
}

interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string n, double p, int q) : base(n, p, q) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "5 percent discount";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string n, double p, int q) : base(n, p, q) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity + 50;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.03;
    }

    public string GetDiscountDetails()
    {
        return "3 percent discount";
    }
}

class Program6
{
    static void Main()
    {
        List<FoodItem> foods = new List<FoodItem>();
        foods.Add(new VegItem("Paneer", 200, 2));
        foods.Add(new NonVegItem("Chicken", 300, 1));

        foreach (FoodItem f in foods)
        {
            Console.WriteLine(f.GetItemDetails());
            Console.WriteLine("Total: " + f.CalculateTotalPrice());
        }
    }
}

using System;

class Product
{
    public static double Discount = 10;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(int productId, string productName, double price, int quantity)
    {
        this.ProductID = productId;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void ShowProduct()
    {
        if (this is Product)
        {
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
        }
    }

    static void Main(string[] args)
    {
        Product p1 = new Product(1, "Laptop", 55000, 2);

        p1.ShowProduct();

        Console.WriteLine("\nUpdating Discount...\n");
        Product.UpdateDiscount(20);

        p1.ShowProduct();
    }
}

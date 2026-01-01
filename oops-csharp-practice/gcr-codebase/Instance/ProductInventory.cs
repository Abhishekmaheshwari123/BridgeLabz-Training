using System;

class Product
{
    public string ProductName;
    public double Price;

    // class variable (shared by all objects)
    public static int TotalProducts = 0;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + ProductName + ", Price: " + Price);
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + TotalProducts);
    }

    static void Main(string[] args)
    {
        Product p1 = new Product("Laptop", 55000);
        Product p2 = new Product("Mouse", 500);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}

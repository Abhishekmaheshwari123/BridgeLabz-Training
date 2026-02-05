using System;
class Product{
    public string ProductName;
    public int DiscountedPrice;
    public Product(string productName, int discountedPrice)
    {
        ProductName = productName;
        DiscountedPrice = discountedPrice;
    }

    public override string ToString()
    {
        return DiscountedPrice +" : "+ProductName;
    }
}
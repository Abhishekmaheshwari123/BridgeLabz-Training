using System.Collections.Generic;

class Inventory
{
    public Dictionary<string, (int price, int stock)> items;

    public Inventory()
    {
        items = new Dictionary<string, (int, int)>()
        {
            { "Milk", (50, 10) },
            { "Bread", (30, 20) },
            { "Eggs", (6, 100) },
            { "Rice", (60, 25) }
        };
    }

    public bool IsAvailable(string item)
    {
        return items.ContainsKey(item) && items[item].stock > 0;
    }

    public int GetPrice(string item)
    {
        return items[item].price;
    }

    public void ReduceStock(string item)
    {
        items[item] = (items[item].price, items[item].stock - 1);
    }
}

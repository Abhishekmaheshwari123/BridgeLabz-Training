using System;

class Cafeteria
{
    static void Main(string[] args)
    {
        string[] menu =
        {
            "1. Veg Sandwich",
            "2. Cheese Pizza",
            "3. Masala Dosa",
            "4. Fried Rice",
            "5. Paneer Roll",
            "6. Cold Coffee",
            "7. Tea",
            "8. Idli Sambar",
            "9. Burger",
            "10. Noodles"
        };

        DisplayMenu(menu);

        Console.Write("\nEnter the menu index (0–9): ");
        int index = int.Parse(Console.ReadLine());

        string selected = GetItemByIndex(menu, index);
        Console.WriteLine("\nYou ordered: " + selected);
    }

    static void DisplayMenu(string[] items)
    {
        Console.WriteLine("----- Cafeteria Menu -----");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(i + " -> " + items[i]);
        }
    }

    static string GetItemByIndex(string[] items, int index)
    {
        if (index < 0 || index >= items.Length)
        {
            return "Invalid choice!";
        }

        return items[index];
    }
}

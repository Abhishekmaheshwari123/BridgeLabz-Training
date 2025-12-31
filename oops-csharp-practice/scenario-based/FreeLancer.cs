using System;

class FreeLancer
{
    static string[] ParseInvoice(string input)
    {
        string[] parts = input.Split(',');
        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].Trim(); 
        }
        return parts;
    }

    static int GetTotalAmount(string[] tasks)
    {
        int total = 0;

        foreach (string task in tasks)
        {
            string[] pieces = task.Split('-');
            string amountPart = pieces[1].Trim();
            string numberOnly = amountPart.Split(' ')[0];
            int amount = int.Parse(numberOnly);
            total += amount;
        }
        return total;
    }

    static void Main()
    {
        Console.WriteLine("Enter invoice string:");
        string input = Console.ReadLine();
        string[] tasks = ParseInvoice(input);
        foreach (var t in tasks)
        {
            Console.WriteLine(t);
        }
        int total = GetTotalAmount(tasks);
        Console.WriteLine("Total Invoice Amount: " + total + " INR");
    }
}

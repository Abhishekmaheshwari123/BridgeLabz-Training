using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string path = "users.csv";

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string email = data[2];
            string phone = data[3];

            if (!Regex.IsMatch(email, emailPattern))
                Console.WriteLine($"Invalid Email Row: {lines[i]}");

            if (!Regex.IsMatch(phone, phonePattern))
                Console.WriteLine($"Invalid Phone Row: {lines[i]}");
        }
    }
}

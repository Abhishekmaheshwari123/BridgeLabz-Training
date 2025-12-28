using System;
class Pallindrome
{
    public static void Main(String[]args)
    {
        string s = Console.ReadLine();
        String temp = "";
        for(int i = s.Length-1; i >= 0; i--)
        {
            temp += s[i];
        }

        if(temp.Equals(s))Console.WriteLine("Pallindrome");
        else Console.WriteLine("Not Pallindrome");
    }
}
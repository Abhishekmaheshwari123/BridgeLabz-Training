using System;

class Palindrome
{
    static bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
                return false;

            i++; j--;
        }

        return true;
    }

    public static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(IsPalindrome(s) ? "Palindrome" : "Not Palindrome");
    }
}

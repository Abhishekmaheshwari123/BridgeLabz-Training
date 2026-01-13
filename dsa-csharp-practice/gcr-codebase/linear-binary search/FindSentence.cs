using System;

class FindSentence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
            arr[i] = Console.ReadLine();
        string word = Console.ReadLine();
        foreach (string s in arr)
            if (s.ToLower().Contains(word.ToLower()))
            {
                Console.WriteLine(s);
                return;
            }
        Console.WriteLine("");
    }
}

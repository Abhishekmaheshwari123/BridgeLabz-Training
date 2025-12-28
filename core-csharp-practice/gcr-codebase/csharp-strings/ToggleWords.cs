using System;
class ToggleWords
{
    public static void Main(string[] args)
    {
        String s = Console.ReadLine();
        char[]arr = new char[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsLower(s[i]))
            {
                arr[i] = char.ToUpper(s[i]);
            }
            else if (char.IsUpper(s[i]))
            {
                arr[i] = char.ToLower(s[i]);
            }
            else arr[i] = s[i];
        }

        Console.WriteLine(new string(arr));
    }
}
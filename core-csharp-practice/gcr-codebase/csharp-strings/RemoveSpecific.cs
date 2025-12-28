using System;
class RemoveSpecific
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        Char remove = Console.ReadLine()[0];
        String ans = "";
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == remove)continue;
            else ans += s[i];
        }

        Console.WriteLine("Modified String :" + ans);
    }
}
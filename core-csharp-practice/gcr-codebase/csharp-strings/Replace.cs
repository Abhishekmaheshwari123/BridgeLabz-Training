using System;
using System.Data;
class Replace
{
    public static void Main(String[] args)
    {
        String s = Console.ReadLine();
        String word = Console.ReadLine();
        String rep = Console.ReadLine();
        String[]arr = s.Split(' ');
        String ans = "";
        foreach (String i in arr)
        {
            if(i.Equals(" "))continue;
            else if(i.Equals(word)) {
                if(rep == " ")continue;
                else ans += rep +" ";
            }
            else ans += i+" ";
        }
        Console.WriteLine(ans);
    }
}
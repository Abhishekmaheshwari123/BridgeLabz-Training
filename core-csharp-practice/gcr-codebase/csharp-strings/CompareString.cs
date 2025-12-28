using System;
class CompareString
{
    public static void Main(String[] args)
    {
        String a = Console.ReadLine();
        String b = Console.ReadLine();

        String ans = solve(a , b);
        if(ans.Equals("Equal")) Console.WriteLine("Both strings are same");
        else if(ans.Equals(a)) Console.WriteLine(a+" is Smaller than "+b);
        else  Console.WriteLine(b+" is Smaller than "+a);
    }

    static String solve(String a, String b)
    {

        for(int i = 0,  j = 0; i < a.Length && j < b.Length; i++,j++)
        {
            if(a[i] < b[i]) return a;
            else if(a[i] > b[i]) return b;            
        }

        if(a.Length == b.Length) return "Equal";
        else if(a.Length < b.Length) return a;
        return b;


    }
}
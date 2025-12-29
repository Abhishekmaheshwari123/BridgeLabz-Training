using System;
using System.Text;

class SentenceFormatter
{
    static string FormatParagraph(string s)
    {
        if (s.Length == 0) return "";
        StringBuilder res = new StringBuilder();
        bool makeUpper = (s[0] >= 'A' && s[0] <= 'Z') ? false : true;
        bool lastWasSpace = false;
        for(int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if(ch == ' ')
            {
                if(!lastWasSpace)
                    res.Append(' ');
                lastWasSpace = true;
                continue;
            }
            if(ch == '.' || ch == '?' || ch == '!' || ch == ',')
            {
                if(res.Length > 0 && res[res.Length - 1] == ' ')
                    res.Remove(res.Length - 1, 1);

                res.Append(ch);
                res.Append(' ');
                lastWasSpace = true;

                makeUpper = (ch == '.' || ch == '?' || ch == '!');
                continue;
            }
            if(makeUpper && ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
                makeUpper = false;
            }
            res.Append(ch);
            lastWasSpace = false;
        }

        string ans = res.ToString();
        int start = 0;
        while (start < res.Length && res[start] == ' ')
            start++;

        int end = res.Length - 1;
        while (end >= 0 && res[end] == ' ')
            end--;

        ans = ans.Substring(start, end - start + 1);


        return res.ToString();
    }

    static int NumberOfWords(String s)
    {
        String[]arr = s.Split(' ');
        return arr.Length;
    }

    static string longest(String s)
    {
        string[] arr = s.Split(' ');
        int maxi =0 ;
        String ans = "";
        foreach(String i in arr)
        {
            if(i.Length > maxi)
            {
                maxi = i.Length;
                ans = i;
            }
        }
        return ans;
    }

    static String replace(String s)
    {
        String from = Console.ReadLine();
        String to = Console.ReadLine();
        s = s.Replace(from,to);
        return s;
    }

    static void Main()
    {
        string input = "Hello.world!my,name is , Abhisek";
        String formatted = FormatParagraph(input);
        Console.WriteLine(formatted);

        int NumberOfWordsInS = NumberOfWords(formatted);
        Console.WriteLine(NumberOfWordsInS);

        String longestString = longest(formatted);
        Console.WriteLine(longestString);

        String replaces = replace(formatted);



    }
}

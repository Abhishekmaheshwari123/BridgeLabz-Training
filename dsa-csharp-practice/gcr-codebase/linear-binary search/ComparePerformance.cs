using System;
using System.Text;
using System.Diagnostics;

class ComparePerformance
{
    static void Main()
    {
        int n = 30000;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        string s = "";
        for (int i = 0; i < n; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}

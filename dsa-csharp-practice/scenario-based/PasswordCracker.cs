using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class PasswordCracker
{
    public static void Main(String[] args)
    {
        string RealPassword = "hello";
        char[]arr = {'e','l','l','o','p'};

        List<char> l = new List<char>();
        int[]vis = new int[arr.Length];

        if(check(RealPassword, l , arr, vis))Console.WriteLine("Got the Password");
        else
        {
            Console.WriteLine("Sorry");
        }
    }

    static Boolean check(string RealPassword, List<char> l , char[] arr, int[]vis)
    {
        if(l.Count == RealPassword.Length)
        {
            string s = "";
            for(int i = 0; i < l.Count; i++)
            {
                s += l[i];
            }

            return s.Equals(RealPassword);
        }

        for(int i = 0; i < arr.Length; i++)
        {
            if(vis[i] == 0)
            {
                vis[i] = 1;
                l.Add(arr[i]);
                if(check(RealPassword , l, arr, vis)) return true;
                vis[i] = 0;
                l.RemoveAt(l.Count - 1);
            }
        }
        return false;
    }
}
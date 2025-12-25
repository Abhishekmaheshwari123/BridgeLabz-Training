using System;
using System.Data;
using System.Security.Principal;
class Factors
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int NumberOffactors = NumberOfFactors(n);
        int[] factors = factor(n , NumberOffactors);
        int sum = CalculateSum(factors);
        int product = CalculateProduct(factors);
        int sumOfSquare = CalculateSumOfSquare(factors);


        Console.Write("Factors : ");
        foreach(int i in factors) Console.Write(i+" ");
        Console.WriteLine();

        Console.WriteLine("sum  "+sum +"   product "+product+"    sumOfSquare "+sumOfSquare);


        

        
        
    }

    static int CalculateSumOfSquare(int[] factor)
    {
        int sum = 0;
        foreach(int i in factor) sum += (int)Math.Pow(i , 2);

        return sum;
    }

    static int CalculateProduct(int[] factor)
    {
        int pro = 1;
        foreach(int i in factor) pro *= i;
        return pro;
    }

    static int CalculateSum(int[] factor)
    {
        int sum = 0;
        foreach(int i in factor) sum += i;
        return sum;
    }

    static int[] factor(int n, int factors)
    {
        int[]ans = new int[factors];
        int l = 0;
        int r = factors-1;
        for(int i = 2; i * i <= n; i++)
        {
            if(n % i == 0)
            {
                if(i*i == n)ans[l++] = i;
                else
                {
                    ans[l++] = i;
                    ans[r--] = (n/i);
                }
            }
        }
        return ans;
    }


    static int NumberOfFactors(int n)
    {
        int factors = 0;
        for(int i = 2; i*i <= n; i++)
        {   
            if(n % i == 0){
                if  (i * i == n) factors++;
                else factors += 2;
            }
        }
        return factors;
    }
}
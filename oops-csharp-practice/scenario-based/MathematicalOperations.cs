using System;
class MathematicalOperations
{
    public static void Main(String[] args)
    {
        Operations op = new Operations();
        Console.WriteLine("Factorial of 4 : "+op.Fact(4));
        Console.WriteLine("5 is a prime : "+op.IsPrime(5));
        Console.WriteLine("Gcd of 4 and 44 : "+op.Gcd(4,44));
        Console.WriteLine("8th Fibonacci Number is : "+op.NthFibonacci(8));
    }
}


internal class Operations
{
    public int Fact(int ele)
    {
        if(ele < 1) return 0;
        if(ele == 1) return ele;
        return ele * Fact(ele - 1);
    }

    public Boolean IsPrime(int ele)
    {
        if(ele <= 1) return false;
        for(int i = 2; i*i <= ele; i++)
        {
            if(ele % i == 0) return false;
        }
        return true;
    }

    public int Gcd(int a, int b)
    {

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public int NthFibonacci(int n)
    {
        if(n < 1) return 0;
        if(n <= 2)return n-1;
        int a = 0;
        int b = 1;
        int ans = a + b;
        for(int i = 2; i < n; i++)
        {
            a = b;
            b = ans;
            ans = a + b;

        }
        return ans;
    }
}
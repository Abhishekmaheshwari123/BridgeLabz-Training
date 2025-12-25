using System;
class Chocolate
{
    public static void Main(String[]args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int[]arr = solve(a,b);
        Console.WriteLine("Chocolate per student "+arr[0]+"   Remaining "+arr[1]);
    }

    static int[] solve(int a, int b)
    {
        int[]ans = new int[2];
        ans[1] = a % b;
        ans[0] = a / b;        
        return ans;
    }
}
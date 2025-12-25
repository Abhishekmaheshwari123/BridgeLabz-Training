using System;
class LargestSmallest
{
    public static void Main(String[]args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int[]arr = solve(a,b,c);
        Console.WriteLine("largest "+arr[0]+"   smallest "+arr[1]);
    }

    static int[] solve(int a, int b, int c)
    {
        int[]ans = new int[2];
        ans[1] = (int)1e9;
        ans[0] = Math.Max(ans[0] , a);
        ans[0] = Math.Max(ans[0] , b);
        ans[0] = Math.Max(ans[0] , c);

        ans[1] = Math.Min(ans[1] , a);
        ans[1] = Math.Min(ans[1] , b);
        ans[1] = Math.Min(ans[1] , c);

        return ans;
    }
}
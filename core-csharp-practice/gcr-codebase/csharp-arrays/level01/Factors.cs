using System;
class Factors
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int temp = n;
        int number = 0;
        for(int i = 2; i*i < n; i++)
        {
            if(n % i == 0)
            {
                if(i*i == n)number++;
                else number+=2;
            }
        }

        int[]factor = new int[number];
        int l = 0;
        int r = factor.Length - 1;
        for(int i = 2; i*i < n; i++)
        {
            if(n % i == 0)
            {
                if(i*i == n)factor[l] = i;
                else
                {
                    factor[l++] = i;
                    factor[r--] = n/i;
                }
            }
        }

        foreach (int ele in factor)
        {
            Console.Write(ele+" ");
        }
    }
}
using System;
class Quadratic
{
    public static void Main(String[]args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int D = b*b - 4*a*c;
        if(D == 0)
        {
            double root = -b / (2*a);
            Console.WriteLine("This Equations has only 1 root : " + root);
        }
        else if(D > 0)
        {
            double[]arr = findRoot(D , a , b);
            Console.WriteLine("This Equation have Two roots are : " + arr[0]+"  "+arr[1]);
        }

        else
        {
            Console.WriteLine("This equations doesn't exits with real roots") ;
        }
    }

    static double[] findRoot(int D, int a, int b)
    {
        double[] ans = new double[2];
        ans[0] = (-b + Math.Sqrt(D)) / (2*a);
        ans[1] = (-b - Math.Sqrt(D)) / (2*a);

        return ans;
        
    }
}
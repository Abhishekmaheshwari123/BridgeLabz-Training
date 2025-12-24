using System;
class Grade
{
    public static void Main(String[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,]arr = new int[n,4];
        for(int i = 0; i < n; i++)
        {
            arr[i,0] = int.Parse(Console.ReadLine());
            arr[i,1] = int.Parse(Console.ReadLine());
            arr[i,2] = int.Parse(Console.ReadLine());
            arr[i,3] = (arr[i,0] + arr[i,1] + arr[i,2]) / 3;            
        }
        for(int i = 0; i < n; i++)
        {
            if(arr[i,3] >= 80) Console.WriteLine("Level 04, above agency-normalized standards");
            else if(arr[i,3] >= 70) Console.WriteLine("Level 04, above agency-normalized standards");
            else if(arr[i,3] >= 60) Console.WriteLine("Level 03, at agency-normalized standards");
            else if(arr[i,3] >= 50) Console.WriteLine("Level 02, below, but approaching  agency-normalized standards");
            else if(arr[i,3] >= 40) Console.WriteLine("Level 01, well below agency-normalized standards");
            else Console.WriteLine("Remedial Standards");
        }
    }
}
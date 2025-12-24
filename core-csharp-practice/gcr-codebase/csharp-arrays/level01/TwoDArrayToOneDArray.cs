using System;
class TwoDArrayToOneArray
{
    public static void Main(String[]args)
    {
        int[,]arr = new int[3,3];

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                arr[i,j] = int.Parse(Console.ReadLine());
            }
        }

        int[] nums = new int[arr.GetLength(0) * arr.GetLength(1)];
        int c = 0;
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                nums[c++] = arr[i,j];
            }
        }

        foreach(int ele in nums)
        {
            Console.Write(ele+" ");
        }
    }
}
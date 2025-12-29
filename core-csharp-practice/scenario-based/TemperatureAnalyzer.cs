using System;
using System.Diagnostics.Contracts;
using System.Security.Permissions;
class TemperatureAnalyzer
{
    public static void Main(String []args)
    {
        float[,]arr = new float[7,24];
        Random rand = new Random();
        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                float value = (float)(-30 + (float)rand.NextDouble() * (90));
                arr[i,j] = value;
            }
        }

        float maxi = -31;
        float mini = 61;
        int hottest = -1;
        int coldest = -1;
        for(int i = 0; i < 7; i++)
        {
            float maxii = -31;
            float minii = 61; 
            float sum = 0;           
            for(int j = 0; j < 24; j++)
            {
                maxii = Math.Max(maxii , arr[i,j]);
                minii = Math.Min(minii , arr[i,j]);
                sum += arr[i,j];
            }
            if(maxii > maxi) {
                maxi = maxii;
                hottest = i;
            }
            if(minii < mini)  {
                mini = minii;
                coldest = i;
            }
            double avg = (double) sum / 24;
            Console.WriteLine("Average temperature on "+(i+1)+" day is "+ (avg));
        }

        Console.WriteLine("Hottest day is "+ hottest+"   coldest day is "+coldest);

    }
}
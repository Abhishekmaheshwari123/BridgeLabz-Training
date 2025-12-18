using System;
class CelsiusToFarenheit
{
    public static void Main(String[] args)
    {
        int cel = Convert.ToInt32(Console.ReadLine());
        float far = ((cel*9) / 5) + 32;

        Console.WriteLine(far);
    }
}
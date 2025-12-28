using System;

class DateTimeOffSet
{
    public static void Main(string[] args)
    {
        DateTimeOffset now = DateTimeOffset.UtcNow;

        Console.WriteLine("GMT  : " + now);

        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        Console.WriteLine("IST  : " + TimeZoneInfo.ConvertTime(now, ist));
        Console.WriteLine("PST  : " + TimeZoneInfo.ConvertTime(now, pst));
    }
}

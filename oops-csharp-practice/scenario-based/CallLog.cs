using System;

class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime Timestamp;

    public CallLog(string phone, string message, DateTime time)
    {
        PhoneNumber = phone;
        Message = message;
        Timestamp = time;
    }

    public void Display()
    {
        Console.WriteLine("Phone: " + PhoneNumber + " | Message: " + Message + " | Time: " + Timestamp);
    }
}

class CallLogManager
{
    CallLog[] logs;
    int index = 0;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
    }

    public void AddCallLog(string phone, string message, DateTime time)
    {
        if (index >= logs.Length)
        {
            Console.WriteLine("Log storage is full.");
            return;
        }

        logs[index] = new CallLog(phone, message, time);
        index++;

        Console.WriteLine("Log added successfully.");
    }

    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine("---- Search Results ----");
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs contain the keyword.");
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine("---- Filtered Logs ----");
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Timestamp >= start && logs[i].Timestamp <= end)
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs found in this time range.");
        }
    }
}

class Program
{
    public static void Main()
    {
        CallLogManager manager = new CallLogManager(5);

        manager.AddCallLog("9876543210", "Network issue reported", DateTime.Now.AddMinutes(-30));
        manager.AddCallLog("9123456780", "Recharge not received", DateTime.Now.AddMinutes(-10));
        manager.AddCallLog("9000000000", "SIM not working", DateTime.Now);

        manager.SearchByKeyword("Recharge");

        DateTime start = DateTime.Now.AddHours(-1);
        DateTime end = DateTime.Now;

        manager.FilterByTime(start, end);
    }
}

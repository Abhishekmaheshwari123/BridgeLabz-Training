using System;

class Device
{
    public string DeviceId { get; set; }
    public string Status { get; set; }
}

class Thermostat : Device
{
    public int TemperatureSetting { get; set; }

    public void DisplayStatus()
    {
        Console.WriteLine(DeviceId + " " + Status + " " + TemperatureSetting);
    }
}

class Program
{
    static void Main()
    {
        Thermostat t = new Thermostat();
        t.DeviceId = "D1";
        t.Status = "On";
        t.TemperatureSetting = 24;
        t.DisplayStatus();
    }
}

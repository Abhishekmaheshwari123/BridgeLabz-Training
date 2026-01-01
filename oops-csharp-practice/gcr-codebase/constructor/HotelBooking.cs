using System;

class HotelBooking
{
    public string GuestName;
    public string RoomType;
    public int Nights;

    public HotelBooking()
    {
        GuestName = "Not Assigned";
        RoomType = "Standard";
        Nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }

    static void Main(string[] args)
    {
        HotelBooking b1 = new HotelBooking();
        Console.WriteLine(b1.GuestName + " - " + b1.RoomType + " - " + b1.Nights);

        HotelBooking b2 = new HotelBooking("Riya", "Deluxe", 3);
        Console.WriteLine(b2.GuestName + " - " + b2.RoomType + " - " + b2.Nights);

        HotelBooking b3 = new HotelBooking(b2);
        Console.WriteLine(b3.GuestName + " - " + b3.RoomType + " - " + b3.Nights);
    }
}

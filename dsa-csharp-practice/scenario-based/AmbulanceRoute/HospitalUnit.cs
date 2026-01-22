using System;

class HospitalUnit
{
    public string Name;
    public bool IsAvailable;
    public HospitalUnit Next;

    public HospitalUnit(string name, bool isAvailable = true)
    {
        Name = name;
        IsAvailable = isAvailable;
        Next = null;
    }
}

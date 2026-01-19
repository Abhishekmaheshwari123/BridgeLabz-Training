public class Parcel
{
    public string Stage;
    public Parcel Next;

    public Parcel(string stage)
    {
        Stage = stage;
        Next = null;
    }
}

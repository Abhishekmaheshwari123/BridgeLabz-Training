using System;

public class ParcelUtility
{
    private Parcel head;

    // Add stage at end
    public void AddStage(string stage)
    {
        Parcel newNode = new Parcel(stage);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Parcel temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add checkpoint after a stage
    public void AddCheckpoint(string afterStage, string newStage)
    {
        Parcel temp = head;

        while (temp != null)
        {
            if (temp.Stage.Equals(afterStage))
            {
                Parcel newNode = new Parcel(newStage);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                Console.WriteLine("Checkpoint added successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Stage not found.");
    }

    // Forward tracking
    public void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel lost or no tracking available.");
            return;
        }

        Parcel temp = head;
        Console.Write("Parcel Journey: ");

        while (temp != null)
        {
            Console.Write(temp.Stage);
            if (temp.Next != null)
                Console.Write(" → ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }

    // Mark parcel lost
    public void MarkLostAfter(string stage)
    {
        Parcel temp = head;

        while (temp != null)
        {
            if (temp.Stage.Equals(stage))
            {
                temp.Next = null;
                Console.WriteLine("Parcel marked lost after: " + stage);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Stage not found.");
    }
}

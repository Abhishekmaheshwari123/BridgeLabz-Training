using System;

class Roundabout
{
    private Vehicle head = null;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void AddVehicle(int id)
    {
        Vehicle newVehicle = new Vehicle(id);

        if (head == null)
        {
            head = newVehicle;
            newVehicle.Next = head;
            return;
        }

        Vehicle temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newVehicle;
        newVehicle.Next = head;
    }

    public void RemoveVehicle(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        Vehicle curr = head, prev = null;

        do
        {
            if (curr.VehicleId == id)
            {
                if (prev != null)
                    prev.Next = curr.Next;
                else
                {
                    Vehicle temp = head;
                    while (temp.Next != head)
                        temp = temp.Next;

                    head = head.Next;
                    temp.Next = head;
                }

                Console.WriteLine("Vehicle "+id+" exited roundabout");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);

        Console.WriteLine("Vehicle not found.");
    }

    public void PrintRoundabout()
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        Vehicle temp = head;
        Console.Write("Roundabout: ");
        do
        {
            Console.Write(temp.VehicleId + " -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(back to start)");
    }
}

using System;

class AmbulanceRoute
{
    private HospitalUnit head;

    public void AddUnit(string name, bool isAvailable = true)
    {
        HospitalUnit newUnit = new HospitalUnit(name, isAvailable);

        if (head == null)
        {
            head = newUnit;
            newUnit.Next = head;
            return;
        }

        HospitalUnit temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newUnit;
        newUnit.Next = head;
    }

    public void DisplayRoute()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;
        do
        {
            Console.Write($"{temp.Name} ({(temp.IsAvailable ? "Available" : "Busy")}) -> ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("BACK TO START");
    }

    public HospitalUnit FindNearestAvailableUnit()
    {
        if (head == null) return null;

        HospitalUnit temp = head;
        do
        {
            if (temp.IsAvailable)
                return temp;

            temp = temp.Next;
        } while (temp != head);

        return null;
    }

    public void RemoveUnit(string unitName)
    {
        if (head == null) return;

        HospitalUnit curr = head;
        HospitalUnit prev = null;

        do
        {
            if (curr.Name == unitName)
            {
                if (curr == head)
                {
                    HospitalUnit last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = curr.Next;
                }

                Console.WriteLine(unitName + " removed for maintenance.");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);

        Console.WriteLine("Unit not found.");
    }
}

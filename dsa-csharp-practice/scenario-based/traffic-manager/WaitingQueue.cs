using System;

class WaitingQueue
{
    private int[] queue;
    private int front = -1, rear = -1;
    private int size;

    public WaitingQueue(int capacity)
    {
        size = capacity;
        queue = new int[size];
    }

    public bool IsFull()
    {
        return rear == size - 1;
    }

    public bool IsEmpty()
    {
        return front == -1 || front > rear;
    }

    public void Enqueue(int vehicleId)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue Overflow! Vehicle cannot enter.");
            return;
        }

        if (front == -1)
            front = 0;

        queue[++rear] = vehicleId;
        Console.WriteLine("Vehicle "+vehicleId+" added to waiting queue.");
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow!");
            return -1;
        }

        return queue[front++];
    }
}

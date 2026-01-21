using System;
class reverseLL
{
    public static void Main(String[] args)
    {
        ListNode head = new ListNode(0);
        ListNode temp = head;

        for(int i = 0; i < 5; i++)
        {
            temp.next = new ListNode(int.Parse(Console.ReadLine()));
            temp = temp.next;
        }
        ListNode tail = reverse(head);

       ListNode tempTail = tail;
       while(tempTail != null && tempTail.data != 1)
        {
            Console.Write(tempTail.data+" -> ");
            tempTail = tempTail.next;
        }
            Console.Write(tempTail.data);



    }

    static ListNode reverse(ListNode head)
    {
        if( head == null || head.next == null) return head;

       ListNode newHead = reverse(head.next);
       ListNode front = head.next;
       front.next = head;
       head.next = null;

       return newHead;
    }
}


class ListNode
{
    public int data;
    public ListNode next;

    public ListNode(int Data)
    {
        data = Data;
        next = null;
    }

}
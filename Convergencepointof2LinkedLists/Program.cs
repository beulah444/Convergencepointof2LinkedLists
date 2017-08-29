using System;
    class Program
    {
       public static void Main()
        {
        LinkedList list = new LinkedList();
        // creating first linked list
        list.head1 = new LinkedList.Node(3);
        list.head1.next = new LinkedList.Node(6);
        list.head1.next.next = new LinkedList.Node(9);
        list.head1.next.next.next = new LinkedList.Node(15);
        list.head1.next.next.next.next = new LinkedList.Node(30);
        // creating second linked list
        list.head2 = new LinkedList.Node(10);
        list.head2.next = new LinkedList.Node(15);
        list.head2.next.next = new LinkedList.Node(30);
        Console.WriteLine("The node of convergence point of given two LinkedLists is " + list.getNode());
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
       }
    }

public class LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public Node head1, head2;
 
    /*function to get the intersection point of two linked
lists head1 and head2 */
    public int getNode()
    {
        int c1 = getCount(head1);
        int c2 = getCount(head2);
        int d;
        if (c1 > c2)
        {
            d = c1 - c2;
            return _getIntesectionNode(d, head1, head2);
        }
        else
        {
            d = c2 - c1;
            return _getIntesectionNode(d, head2, head1);
        }
    }
    /* function to get the inters list head11 and head2 where heaad2*/
    int _getIntesectionNode(int d,Node node1,Node node2)
    {
        int i;
        Node current1 = node1;
        Node current2 = node2;
        for(i=0;i<d;i++)
        {
            if(current1 == null)
            {
                return -1;
            }
            current1 = current1.next;
        }
        while (current1 != null && current2 != null)
        {
            if (current1.data == current2.data)
            {
                return current1.data;
            }
            current1 = current1.next;
            current2 = current2.next;
        }
        return -1;
    }
    /*Takes head pointer of the linked list and
    returns the count of nodes in the list */
    int getCount(Node node)
    {
        Node current = node;
        int count = 0;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }
   
}
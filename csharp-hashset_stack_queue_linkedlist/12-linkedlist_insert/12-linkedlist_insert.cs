using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.First == null || n < myLList.First.Value)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        LinkedListNode<int> current = myLList.First;

        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        myLList.AddAfter(current, newNode);

        return newNode;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 21);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}

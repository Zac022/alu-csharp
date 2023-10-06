using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return; // Index is out of range
        }

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                myLList.Remove(current);
                break;
            }

            current = current.Next;
            currentIndex++;
        }
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

        Console.WriteLine("-------------------");
        LList.Delete(myLList, 5); // Delete node at index 5

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}

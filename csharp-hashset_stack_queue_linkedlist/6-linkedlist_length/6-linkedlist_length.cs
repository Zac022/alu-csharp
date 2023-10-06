using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        LinkedListNode<int> currentNode = myLList.First;

        while (currentNode != null)
        {
            count++;
            currentNode = currentNode.Next;
        }

        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(972);
        myLList.AddLast(0);
        myLList.AddLast(8);
        myLList.AddLast(98);
        myLList.AddLast(-4);
        myLList.AddLast(8);

        Console.WriteLine(LList.Length(myLList));
    }
}

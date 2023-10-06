using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        if (size <= 0)
        {
            return linkedList;
        }

        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WriteLine(i);
        }

        return linkedList;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size;

        size = 8;

        llist = LList.CreatePrint(size);
        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
}

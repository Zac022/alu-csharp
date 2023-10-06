using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
        {
            return 0; // List is empty, return 0
        }

        int headValue = myLList.First.Value;
        myLList.RemoveFirst();

        return headValue;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }
}


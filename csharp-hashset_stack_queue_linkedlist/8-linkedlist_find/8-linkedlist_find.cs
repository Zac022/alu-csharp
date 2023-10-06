using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
        foreach (int item in myLList)
        {
            if (item == value)
            {
                return index;
            }
            index++;
        }
        return -1; // Value not found
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 16));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 1));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, -10));
    }
}


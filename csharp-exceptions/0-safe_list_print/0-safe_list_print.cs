using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            foreach (int item in myList)
            {
                if (count >= n)
                    break;

                Console.WriteLine(item);
                count++;
            }
            return count;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}


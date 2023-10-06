using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // Create HashSets to store unique elements from each list
        HashSet<int> uniqueElements1 = new HashSet<int>(list1);
        HashSet<int> uniqueElements2 = new HashSet<int>(list2);

        // Create a List to store different elements
        List<int> differentElements = new List<int>();

        // Iterate through list1 and check if elements are in list2 HashSet
        foreach (int num in list1)
        {
            if (!uniqueElements2.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        // Iterate through list2 and check if elements are in list1 HashSet
        foreach (int num in list2)
        {
            if (!uniqueElements1.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        // Sort the different elements list
        differentElements.Sort();

        return differentElements;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> myList2 = new List<int>() { 0, 2, 4, 6, 7, 8 };
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // Create a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // Iterate through the list and add unique integers to the HashSet
        foreach (int num in myList)
        {
            uniqueIntegers.Add(num);
        }

        // Calculate the sum of unique integers
        int sum = 0;
        foreach (int uniqueNum in uniqueIntegers)
        {
            sum += uniqueNum;
        }

        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 8 };
        List<int> myList2 = new List<int>() { 98, 98, -14, 972, 0, -42, -972 };

        Console.WriteLine(List.Sum(myList1));
        Console.WriteLine(List.Sum(myList2));
    }
}

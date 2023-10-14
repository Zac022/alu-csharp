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


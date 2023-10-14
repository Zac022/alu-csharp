using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // Create a HashSet to store unique elements from list1
        HashSet<int> uniqueElements = new HashSet<int>(list1);

        // Create a List to store common elements
        List<int> commonElements = new List<int>();

        // Iterate through list2 and check if elements are in the HashSet
        foreach (int num in list2)
        {
            if (uniqueElements.Contains(num))
            {
                commonElements.Add(num);
            }
        }

        // Sort the common elements list
        commonElements.Sort();

        return commonElements;
    }
}

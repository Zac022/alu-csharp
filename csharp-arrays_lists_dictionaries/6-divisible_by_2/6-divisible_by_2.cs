using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        foreach (int number in myList)
        {
            bool isDivisibleBy2 = number % 2 == 0;
            result.Add(isDivisibleBy2);
        }

        return result;
    }
}


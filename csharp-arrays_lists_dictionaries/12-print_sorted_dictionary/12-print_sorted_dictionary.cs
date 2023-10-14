using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Get the keys and sort them
        List<string> sortedKeys = new List<string>(myDict.Keys);
        sortedKeys.Sort();

        // Iterate through the sorted keys and print the corresponding values
        foreach (string key in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}



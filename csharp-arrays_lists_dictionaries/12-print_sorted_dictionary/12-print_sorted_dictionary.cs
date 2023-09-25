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

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Console.WriteLine("Sorted Dictionary:");
        Dictionary.PrintSorted(myDict);
    }
}

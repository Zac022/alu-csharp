using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Check if the key already exists in the dictionary
        if (myDict.ContainsKey(key))
        {
            // Key exists, so update the value
            myDict[key] = value;
        }
        else
        {
            // Key doesn't exist, so add a new key-value pair
            myDict.Add(key, value);
        }

        return myDict;
    }
}


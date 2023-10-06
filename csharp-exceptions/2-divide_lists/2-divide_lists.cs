using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    Console.WriteLine("Out of range");
                    break;
                }

                if (list2[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else
                {
                    result.Add(list1[i] / list2[i]);
                }
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 1, 20, 16, 15, 54 };
        List<int> list2 = new List<int>() { 1, 0, 2, 3 };
        List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}


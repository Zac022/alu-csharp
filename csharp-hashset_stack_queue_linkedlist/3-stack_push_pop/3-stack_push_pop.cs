using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Top item: Stack is empty");
            Console.WriteLine($"Stack contains \"{search}\": False");
            aStack.Push(newItem);
            return aStack;
        }

        string topItem = aStack.Peek();
        Console.WriteLine($"Top item: {topItem}");

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            while (aStack.Count > 0)
            {
                string item = aStack.Pop();
                if (item == search)
                {
                    break;
                }
            }
        }

        aStack.Push(newItem);
        return aStack;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}

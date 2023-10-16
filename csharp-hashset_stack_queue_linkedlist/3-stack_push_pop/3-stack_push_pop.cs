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


using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0)
        {
            Console.WriteLine("First item: Queue is empty");
            Console.WriteLine($"Queue contains \"{search}\": False");
            aQueue.Enqueue(newItem);
            return aQueue;
        }

        string firstItem = aQueue.Peek();
        Console.WriteLine($"First item: {firstItem}");

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                {
                    break;
                }
            }
        }

        aQueue.Enqueue(newItem);
        return aQueue;
    }
}


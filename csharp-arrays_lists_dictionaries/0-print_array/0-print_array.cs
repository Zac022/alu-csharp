using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return new int[0]; // Return an empty array
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0]; // Return an empty array
        }

        int[] newArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write(i + " ");
        }
        Console.WriteLine();

        return newArray;
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5]; // Create a 5x5 array

        // Initialize the array with 0's
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = 0;
            }
        }

        // Set index [2, 2] to 1
        array[2, 2] = 1;

        // Print the array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

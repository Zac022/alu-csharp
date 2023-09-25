using System;

namespace MyNamespace // Optionally, use a namespace to avoid global namespace conflicts
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            else if (size == 0)
            {
                Console.WriteLine();
                return new int[0];
            }

            int[] NumberList = new int[size];
            for (int i = 0; i < size; i++)
            {
                NumberList[i] = i;
                if (i < size - 1)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.Write($"{i}");
                }
            }
            Console.WriteLine();

            return NumberList;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray;

            newArray = Array.CreatePrint(5);
            Console.WriteLine("Array Length: " + newArray.Length);
        }
    }
}

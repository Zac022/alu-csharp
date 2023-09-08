using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number < 100; number++)
        {
            if (number < 10)
            {
                Console.Write("0" + number);
            }
            else
            {
                Console.Write(number.ToString());
            }

            if (number < 99)
            {
                Console.Write(", ");
            }
            else
            {
                Console.Write("\n");
            }
        }
    }
}

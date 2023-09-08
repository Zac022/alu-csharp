using System;

class Program
{
    static void Main(string[] args)
    {
        for (int tensDigit = 0; tensDigit <= 8; tensDigit++)
        {
            for (int onesDigit = tensDigit + 1; onesDigit <= 9; onesDigit++)
            {
                Console.Write($"{tensDigit}{onesDigit}");

                if (tensDigit < 8 || onesDigit < 9)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

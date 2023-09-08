using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        // Take the absolute value of the number to handle negative numbers
        number = Math.Abs(number);

        // Get the last digit by taking the remainder when dividing by 10
        int lastDigit = number % 10;

        Console.Write(lastDigit); // Print the last digit

        return lastDigit; // Return the last digit
    }
}

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine();
        Console.WriteLine(r);
    }
}

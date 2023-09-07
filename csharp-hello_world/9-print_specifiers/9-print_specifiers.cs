using System;

class Program
{
    static void Main()
    {
        double percent = 75.53;
        double currency = 98765.43;

        Console.WriteLine($"Percent: {percent.ToString("0.00")}% tip");
        Console.WriteLine($"Currency: {currency.ToString("C2")}");
    }
}

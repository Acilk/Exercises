using System;

namespace Taxes;

class Program
{
    static void Main(string[] args)
    {
        double income;
        double taxes;

        Console.WriteLine("Welcome in 'Tax Calculator'.");
        Console.WriteLine("");
        Console.Write("Please enter your annual income: ");

        if (!double.TryParse(Console.ReadLine(), out income))
        {
            Console.WriteLine("Invalid value. Please, enter a number.");
            return;
        }

        taxes = TaxesCalculator(income);

        Console.WriteLine($"The income tax payable is {taxes:F2}");

    }

    public static double TaxesCalculator(double income)
    {
        double taxes;

        if(income <= 85528)
        {
            taxes = (income * 18 / 100) - 556.02;
        }
        else
            taxes =((income - 85528) * 32 / 100) + 14839.02;


        return taxes;
    }
}

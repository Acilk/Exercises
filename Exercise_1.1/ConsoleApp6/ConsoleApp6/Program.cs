using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        double result;
        double x;
        double y;

        Console.WriteLine("Welcome in the Calculator!");

        Console.WriteLine("Please enter two real numbers and choose a operation.");

        do
        {
            Console.Write("First number: ");
            Console.WriteLine("");
            while(!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Please, enter a number which is a double value.");
            }

            Console.Write("Operation (+ - * /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Secound number: ");
            Console.WriteLine("");
            while(!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Please, enter a number which is a double value.");
            }

            result = Calc(x, y, operation);

            Console.WriteLine($"Your result is: {result}");
            Console.WriteLine("If you want to exit than press 'Enter' key.");

            keyInfo = Console.ReadKey(true);
        } while (keyInfo.Key != ConsoleKey.Enter);
    }

    public static double Calc(double x, double y, char operation)
    {
        double result = 0;

        switch (operation)
        {
            case '+':
                result = x + y;
                break;

            case '-':
                result = x - y;
                break;

            case '/':
                if (y == 0)
                    Console.WriteLine("Error: division by zero.");
                else
                {
                    result = x / y;
                }
                break;

            case '*':
                result = x * y;
                break;
            default:
                Console.WriteLine("Error: invalid operation symbol.");
                break;
        }

        return result;
    }
}

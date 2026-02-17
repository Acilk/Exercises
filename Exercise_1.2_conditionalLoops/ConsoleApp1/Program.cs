using System;
using System.Diagnostics;

namespace OddNEven;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        Console.WriteLine("Welcome in OddNEven program!");
        Console.WriteLine("Please, enter a integer: ");
        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer! Please, try again.");
        }

        for(int i = 1; i <= number; i += 2)
        {
            Console.Write($"{i} ");
        }
    }
}

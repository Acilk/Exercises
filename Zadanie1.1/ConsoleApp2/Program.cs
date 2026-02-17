using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Header
            Console.WriteLine("Welcome in Comparison app!");
            Console.WriteLine("Please, enter 3 numbers below:");

            bool isEntering = true;
            //2. App ask for a 3 integers to comparison
            //3.1. Loop menu
            try
            {
                while(isEntering)
                {
                    //3.2. App get numbers from user
                    int[] numbers = new int[3];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"Number {i + 1}: ");
                        // Odczytaj ciąg znaków i skonwertuj na int
                        string input = Console.ReadLine() ?? "";
                        if (!string.IsNullOrEmpty(input))
                        {
                            numbers[i] = int.Parse(input);
                        }
                    }

                    Array.Sort(numbers);
                    Array.Reverse(numbers);

                    foreach(int number in numbers)
                    {
                        Console.Write(number + " ");
                    }
                    
                    isEntering = false;
                }
            }  
            catch(ArgumentException e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
                throw;
            }  
        }
    }
}


using System;
using System.Globalization;
using System.Security.Authentication.ExtendedProtection;

namespace arithmeticSequence;

class Program
{
    static void Main(string[] args)
    {
        int min = 0, max = 0, number, firstNumber, index = 0;
        int[] numbers = new int[100];
        bool firstBool = true;
        double arthmeticMean;

        while (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber == 0)
        {
            Console.WriteLine("Invalid integer, please try again!. ");
        }

        max = min = firstNumber;

        while (true)
        {
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid integer, please try again!. ");
            }

            if(number == 0)
                break;

            if(index < numbers.Length)
            {
                numbers[index] = number;
                index++;
            }
            
                if(number > max)
                {
                    max = number;
                }
                else if(number < min)
                    min = number;  
        } 

        arthmeticMean = (min + max)/2.0;

        for(int i = 0; i < index; i++)
        {
            if(firstBool)
            {
                Console.Write("Your arthmetic sequence is: " + firstNumber + " ");
                firstBool = false;
            }

            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine("");

        Console.WriteLine($"Your sum of min&max: {arthmeticMean * 2}");

        Console.WriteLine($"Your min of arthmetic sequence: {min}");
        Console.WriteLine($"Your max of arthmetic sequence: {max}");

        Console.WriteLine($"Your mean of arthmetic sequence: {arthmeticMean}");

    }
}

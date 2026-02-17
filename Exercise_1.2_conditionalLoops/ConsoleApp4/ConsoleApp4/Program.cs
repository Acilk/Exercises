using System;

namespace sumofwhole;

class Program
{
    static void Main(string[] args)
    {
        int number, sum = 0;

        do
        {
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"The {number} is invalid integer. Please, try again: ");
            }

            //if(number == 0) W tej konfiguracji po wpisaniu '0' jako integer, dojdzie do przerwania pętli while(true) - oczywiście zamiast pętli do-while.
            //  break;        Program na tym etapie dodaje 0 do zmiennej 'sum', więc jak program musiałby liczyć średnią arytmetyczną to wykonywałby błędne wyliczenia.

            sum += number;


        }while(number != 0);

        Console.WriteLine($"Sum of numbers is {sum}.");
    }
}
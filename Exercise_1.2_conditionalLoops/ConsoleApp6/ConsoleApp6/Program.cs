using System;
using System.Security.Cryptography;

namespace HighOrLowGame;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int safeNumber = RandomNumberGenerator.GetInt32(1, 101);
        bool isEnd = true;


        while(isEnd)
        {
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid integer, please try again!");
            }

            if(number == safeNumber)
            {
                isEnd = false;
                Console.WriteLine("Congratulations!");
            }
            else if(number > safeNumber)
            {
                Console.WriteLine("Your number is too big!");
            }
            else
                Console.WriteLine("Your number is too small!");
        }
    }
}
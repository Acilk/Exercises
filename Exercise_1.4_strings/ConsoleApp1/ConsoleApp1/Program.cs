using System;
using System.Collections.Generic;

namespace LastChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] lastChar = input.ToCharArray();
            char lastLetter = lastChar[lastChar.Length - 1];
            int numberOfLC = 0;
       
            foreach (char c in lastChar)
            {  
                Console.WriteLine(c); 
            }

            foreach (char c in lastChar)
            {
                if (lastLetter == c)
                {
                    numberOfLC++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(numberOfLC - 1);
        }
    }
}
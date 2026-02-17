using System;

namespace Dividrs;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, Please try again! ");
        }

        int temp = Math.Abs(number);

        if(number < 0)
        {
            for (int i = number; i < 0; i++)
            {
                if (temp % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        
        for (int i = 1; i <= temp; i++)
        {
            if (temp % i == 0)
            {
                Console.Write(i + " ");
            }
        } 
    }
}
using System;

namespace primeNumbers;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, please try again ");
        }

        bool[] primes = new bool[number + 1];

        for(int i = 2; i <= number; i++)
        {
            primes[i] = true;
        }
        

            for(int i = 2; i * i <= number; i++)
            {
                if(primes[i])
                {
                    for (int j = i * i; j <= number; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            if (primes[number])
            {
                Console.WriteLine(number + " is a prime number!");
            }
            else
                Console.WriteLine(number + " isn't a prime number!");
        
    }
}
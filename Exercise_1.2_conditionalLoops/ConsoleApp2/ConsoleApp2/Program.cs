using System;
using System.Security.Cryptography;

namespace ABSum;

class Program
{
    static void Main(string[] args)
    {
        int A, B, N, Sum;
        bool end = true;

        Console.WriteLine("Welcome in ABSum program!");
        do
        {
            Console.WriteLine("Please, enter a two integers. First have to be smaller than secound!:");
            while (!int.TryParse(Console.ReadLine(), out A))
            {
                Console.WriteLine("Invalid input. Try again.");
            }

            while (!int.TryParse(Console.ReadLine(), out B))
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }while(A >= B);

        N = B - A + 1;

        do
        {
            Sum = ((A + B) * N) / 2;
            Console.WriteLine($"{Sum}");
            end = false;
        } while(end);

        end = true;

        while(end)
        {
            Sum = ((A + B) * N) / 2;
            Console.WriteLine($"{Sum}");
            end = false;
        }

        for(int i = 0; i < 1; i++)
        {
            Sum = ((A + B)*N)/2;
            Console.WriteLine($"{Sum}");
        }

        /*Sum = 0;

        for (int i = A; i <= B; i++)
        {
            Sum += i;
        }

        Console.WriteLine(Sum);

        Sum = 0;

        do
        {
            Sum += A;
            A++;
        }
        while (A <= B);

        Console.WriteLine(Sum);


        while (A <= B)
        {
            Sum += A;
            A++;
        }

        Console.WriteLine(Sum);*/
    }
}

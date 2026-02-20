using System;
using System.Globalization;
using System.Security.Cryptography;

namespace matrices;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] numbers = new int[5,5];
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        Random rnd = new Random();

        Console.WriteLine("Numbers of matric:");
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int randomNumber = rnd.Next(-5, 6);
                numbers[i, j] = randomNumber;
                Console.Write($"{numbers[i, j], 4}");
            }
            Console.WriteLine();
        }
        
        for(int j = 0; j < columns; j++)
        {
            int min = numbers[0, j];
            int max = numbers[0, j];

            for (int i = 1; i < rows; i++)
            {
                if(numbers[i, j] < min)
                {
                    min = numbers[i, j];
                }
                
                if(numbers[i, j] > max)
                {
                    max = numbers[i, j];
                }
            }

            Console.WriteLine($"Column {j} Min: {min}, Max: {max}");
        }

    }
}

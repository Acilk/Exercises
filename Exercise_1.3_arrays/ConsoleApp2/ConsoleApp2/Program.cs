using System;

namespace howManyNumbers;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        int[] appearedNumber = new int[11];
        Random rnd = new Random();
        
        Console.WriteLine("Drawn numbers:");
        for(int i = 0; i < 20; i++)
        {
            int randomNumber = rnd.Next(1, 11);
            numbers[i] = randomNumber;

            Console.Write(numbers[i] + " ");

            for(int j = 0; j <= 10; j++)
            {
                if(j == numbers[i])
                {
                    appearedNumber[j] += 1;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Appeard of number:");
        for(int i = 1; i < 11; i++)
        {
            Console.WriteLine(i + "-" + appearedNumber[i]);
        }

    }
}

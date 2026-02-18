using System;

namespace randomArrays;

class Program
{
    static void Main(string[] args)
    {
        int min = 0, max = 0, mean = 0, sum = 0, greater = 0, smaller = 0;
        int[] numbers = new int[10];
        Random rnd = new Random();

        Console.WriteLine("Drawn numbers:");
        for(int i = 0; i < 10; i++)
        {
            int randomNumber = rnd.Next(-10, 10);
            numbers[i] = randomNumber;
            sum += numbers[i];
            Console.Write(numbers[i] + " ");
        }

        mean = sum / 10;

        for (int i = 0; i < 10; i++)
        {
            if(numbers[i] <= min)
            {
                min = numbers[i];
            }
            else if(numbers[i] > min && numbers[i] > max)
            {
                max = numbers[i];
            }

            if(numbers[i] < mean)
            {
                smaller++;
            }
            else
                greater++;
        }

        Array.Reverse(numbers);

        Console.WriteLine();
        Console.WriteLine("Min: " + min + ", Max:  " + max);
        Console.WriteLine("Mean: " + mean);
        Console.WriteLine("Smaller than mean: " + smaller);
        Console.WriteLine("Greater than mean: " + greater);
        Console.WriteLine("Numbers in reverse order: ");
        foreach (int l in numbers)
        {
            Console.Write(l + " ");
        }

    }
}
using System;

namespace randomArrays;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Random rnd = new Random();

        for(int i = 0; i < 10; i++)
        {
            int randomNumber = rnd.Next(-10, 10);
            numbers[i] = randomNumber;
            Console.Write(numbers[i] + " ");
        }
    }
}
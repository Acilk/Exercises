using System;

namespace powNumb;

class Program
{
    static void Main(string[] args)
    {
        int num;

        while(!int.TryParse(Console.ReadLine(), out num) || num <= 0)
        {
            Console.WriteLine("Invalid integer, please try again! ");
        }

        for(int i = 1; i <= num;)
        {
            Console.WriteLine(i);
            i = i * 2;
        }
    }
}
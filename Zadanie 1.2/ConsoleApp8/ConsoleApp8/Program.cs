using System;

namespace christmasTree;

class Program
{
    static void Main(string[] args)
    {
        char sign = '*';
        int high  = 0;

        while(!int.TryParse(Console.ReadLine(), out high))
        {
            Console.WriteLine("Invalid integer, please try again! ");
        }

        for(int i = 0; i < high; i++)
        {
            for(int k = 0; k < high - i - 1; k++)
            {
                Console.Write(" ");
            }
            for(int j = 0; j < 2 * i + 1; j ++)
            { 
                Console.Write(sign);
            }
            Console.WriteLine();
        }    
    }
}

using System;
using System.Linq.Expressions;

namespace binaryConverter;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        int index = 0;
        int[] binaryNumbers = new int[32];

        Console.WriteLine("Please, enter a integer to binary convert: ");

        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, please try again! ");
        }

        int n = Math.Abs(number);

        if(n == 0)
        {
            binaryNumbers[index++] = 0;
        }
        else
        {
            while (n > 0 && index < 32)
            {
                binaryNumbers[index] = n % 2;
                n = n / 2;
                index++;
            }
        }    

        if(number >= 0)
        {
            Console.Write("0.");
        }
        else if(number < 0)
        {
            Console.Write("1.");
        }

        for(int i = index - 1; i >= 0; i--)
        {
            Console.Write(binaryNumbers[i]);
        }
        
        


    }
}
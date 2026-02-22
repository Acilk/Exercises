using System;
using System.Linq.Expressions;

namespace binaryConverter;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        int[] binaryNumbers = new int[32];

        Console.WriteLine("Please, enter a integer to binary convert: ");

        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, please try again! ");
        }

        int n = Math.Abs(number);

       
        
        for(int i = 0; i < 32; i++)
        {
            binaryNumbers[i] = n % 2;
            n /= 2;
        }
        


        Console.Write("ZM: ");
        if (number >= 0)
        {
            Console.Write("0.");
        }
        else if(number < 0)
        {
            Console.Write("1.");
        }

        for(int i = 31; i >= 0; i--)
        {
            Console.Write(binaryNumbers[i]);
        }
        
        if(number < 0)
        {
            int[] zu1 = new int[32];
            int[] zu2 = new int[32];

            Array.Copy(binaryNumbers, zu1, 32);
            Array.Copy(binaryNumbers, zu2, 32);

            for (int i = 0; i < 32; i++)
            {
                if(zu1[i] == 0)
                {
                    zu1[i] = 1;
                }
                else if(zu1[i] == 1)
                {
                    zu1[i] = 0;
                }
            }

            Console.WriteLine();
            Console.Write("ZU1:  ");
            for (int i = 31; i >= 0; i--)
            {
                Console.Write(zu1[i]);
            }

            for(int i = 0; i < 32; i++)
            {
                zu2[i] = zu1[i];
            }

            for(int i = 0; i < 32; i++)
            {
                if(zu2[i] == 0)
                {
                    zu2[i] = 1;
                    break;
                }
                else
                {
                    zu2[i] = 0;
                }
            }

            Console.WriteLine();
            Console.Write("ZU2:  ");
            for(int i = 31; i >= 0; i--)
            {
                Console.Write(zu2[i]);
            }
        }

    }
}
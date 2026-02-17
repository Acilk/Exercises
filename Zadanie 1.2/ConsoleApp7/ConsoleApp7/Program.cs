using System;

namespace square;

class Program
{
    static void Main(string[] args)
    {
        char ch;
        int number, enter, x = 1, y = 1, a, b;
        enter = a = b = 0;


        Console.WriteLine("Please, enter a character: ");

        char.TryParse(Console.ReadLine(), out ch);

        Console.WriteLine("Please, enter 4 values: position of x, position of y, lenght a and lenght b.");

        while(enter != 4)
            {
                while(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid integer, please try again!");
                }

                enter++;

                switch(enter)
                {
                    case 1:
                        x = number;
                        break;
                    case 2:
                        y = number;
                        break;
                    case 3:
                        a = number;
                        break;
                    case 4:
                        b = number;
                        break;
                }
            }



        Console.Clear();

        for (int row = 1; row <= y + a; row++)
        {
            for (int col = 1; col <= x + b; col++)
            {
                if (row >= y && row < y + a &&
                    col >= x && col < x + b)
                {
                    Console.Write(ch);   // jesteśmy w prostokącie
                }
                else
                {
                    Console.Write(" ");  // poza prostokątem
                }
            }
            Console.WriteLine();
        }


        Console.WriteLine("");
        Console.WriteLine($"{ch}, {x}, {y}, {a}, {b}");


    }
}

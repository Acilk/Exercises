using System;

namespace array;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;

        while(!int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            Console.WriteLine("Invalid integer, please try again! ");
        }

        bool[,] a = new bool[n,n];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(nwd(i + 1, j + 1) == 1)
                {
                    a[i,j] = true;
                }
                else
                    a[i,j] = false;
            }
        }

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(a[i,j])
                {
                    Console.Write("+ ");
                }
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }



    }

    static int nwd(int a, int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
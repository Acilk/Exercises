using System;

namespace sumOfTwo;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int sum = 0;
        int odd = 0;
        int even = 0;
        int evenLoop = 0;
        int oddLoop = 0;
        double ArithmeticOdd = 0;
        double ArithmeticEven = 0;
        double ratio = 0;

        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid integer, Please try again! ");
        }

        int temp = Math.Abs(number);

        while (temp > 0)
        {
            sum += temp % 10;
            int numberX = temp % 10;

            if (numberX % 2 == 0)
            {
                even += numberX;
                Console.Write($"{numberX}P ");
                evenLoop++;
            }
            else
            {
                odd += numberX;
                Console.Write($"{numberX}N ");
                oddLoop++;
            }
            temp /= 10;
        }

        if(oddLoop > 0)
            ArithmeticOdd = (double)odd / oddLoop;

        if(evenLoop > 0)
            ArithmeticEven = (double)even / evenLoop;
        
        if(evenLoop > 0 && oddLoop > 0)
        {
            ratio = ArithmeticEven / ArithmeticOdd;
        }
        else
        {
            ratio = double.NaN;
        }

        Console.WriteLine();
        Console.WriteLine("Sum of numbers: " + sum);
        Console.WriteLine("Sum of odd: " + odd);
        Console.WriteLine("Sum of even: " + even);
        Console.WriteLine("Arithmetic of Odds: " + ArithmeticOdd);
        Console.WriteLine("Arithmetic of Even: " + ArithmeticEven);
        Console.WriteLine("Ratio of numbers is: " + ratio);
        Console.WriteLine("odd loops: " + oddLoop);
        Console.WriteLine("even loops: " + evenLoop);
        
    }
}

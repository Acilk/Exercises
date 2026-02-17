using System;

namespace InstallmentCalculator;

class Program
{
    static void Main(string[] args)
    {
        double price = 0;
        int installment = 0 ;
        double credit;

        Console.WriteLine("Welcome in 'Installment Calculator'.");
        Console.WriteLine("");
        Console.WriteLine("Please enter a price for a product and amount of installment.");

        while(!(price >= 100 && price <= 10000))
        {
            Console.Write("Price for a product: " + "[100-10000]");
            if(!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid value. Please, enter a number.");
            }
        }
        
            Console.WriteLine("");

        while(!(installment >= 6 && installment <= 48))
        {

            Console.Write("Amount of installment: " + "[6-48]");
            if(!int.TryParse(Console.ReadLine(), out installment))
            {
                Console.WriteLine("Invalid value. Please, enter a number.");
            }
        }


        credit = InstallmentCalc(price, installment);

        Console.WriteLine($"The monthly installment is {credit:F2}");

    }

    public static double InstallmentCalc(double price, int installment)
    {
        double interest = 0;
        double credit;
        double interestRate;

        if (installment >= 6 && installment <= 12)
        {
            interest = 0.025;
        }
        else if(installment >= 13 && installment <= 24)
        {
            interest = 0.05;
        }
        else if(installment >= 25 && installment <= 48)
        {
            interest = 0.1;
        }

        interestRate = interest / 12;

        credit = price * ((interestRate * Math.Pow(1 + interestRate, installment)) / (Math.Pow(1 + interestRate, installment) - 1));

        return credit;
    }
}
using System;

namespace InstallmentCalculator;

public class Tests
{
    public static void RunTests()
    {
        Console.WriteLine("Running tests for Installment Calculator...");
        Console.WriteLine();

        // Case 1: 6-12 months, interest 0.025, using installment = 6
        Console.WriteLine("Case 1: 6-12 months (interest 2.5%)");
        for (int i = 0; i < 10; i++)
        {
            double price = 100 + i * 100; // 100, 200, ..., 1000
            double expected = CalculateExpected(price, 6, 0.025);
            double actual = Program.InstallmentCalc(price, 6);
            if (Math.Abs(expected - actual) < 0.01)
            {
                Console.WriteLine($"Test {i + 1}: PASS - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
            else
            {
                Console.WriteLine($"Test {i + 1}: FAIL - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
        }
        Console.WriteLine();

        // Case 2: 13-24 months, interest 0.05, using installment = 13
        Console.WriteLine("Case 2: 13-24 months (interest 5%)");
        for (int i = 0; i < 10; i++)
        {
            double price = 100 + i * 100;
            double expected = CalculateExpected(price, 13, 0.05);
            double actual = Program.InstallmentCalc(price, 13);
            if (Math.Abs(expected - actual) < 0.01)
            {
                Console.WriteLine($"Test {i + 1}: PASS - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
            else
            {
                Console.WriteLine($"Test {i + 1}: FAIL - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
        }
        Console.WriteLine();

        // Case 3: 25-48 months, interest 0.1, using installment = 25
        Console.WriteLine("Case 3: 25-48 months (interest 10%)");
        for (int i = 0; i < 10; i++)
        {
            double price = 100 + i * 100;
            double expected = CalculateExpected(price, 25, 0.1);
            double actual = Program.InstallmentCalc(price, 25);
            if (Math.Abs(expected - actual) < 0.01)
            {
                Console.WriteLine($"Test {i + 1}: PASS - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
            else
            {
                Console.WriteLine($"Test {i + 1}: FAIL - Price: {price}, Expected: {expected:F2}, Actual: {actual:F2}");
            }
        }
        Console.WriteLine("Tests completed.");
    }

    private static double CalculateExpected(double price, double installment, double interest)
    {
        double interestRate = interest / 12;
        return price * ((interestRate * Math.Pow(1 + interestRate, installment)) / (Math.Pow(1 + interestRate, installment) - 1));
    }
}
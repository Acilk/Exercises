using System;

namespace BMI;

class Program
{
    static void Main(string[] args)
    {
        double weight;
        double height;
        double bmi;

        Console.WriteLine("Welcome in 'Calc your BMI'!");
        Console.WriteLine("Please, enter your Weight and Height below");
        Console.WriteLine("");

        Console.Write("Weight[kg]: ");
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid weight. Please enter a positive number.");
            return;
        }
        Console.Write("Height[m]: ");
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid height. Please enter a positive number.");
            return;
        }

        bmi = CalculateBMI(weight, height);

        if (bmi >= 24.9)
        {
            Console.WriteLine("Overweight");
        }
        else if (bmi <= 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else 
            Console.WriteLine("Good weight");

        Console.WriteLine($"Your BMI is {bmi:F2}");
    }

    public static double CalculateBMI(double weight, double height)
    {
        return weight / Math.Pow(height, 2);
    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEntering = true;

            //1. Header
            Console.WriteLine("Welcome in a Converter of Temperature!");
            //2. Loop menu
            while (isEntering)
            {
                //3. App ask for a Temperature value
                Console.WriteLine("Please, enter a current temperature in the Celsius unit below:");
                //4. Entering a value - if u write a diffrent value then double, app will ask again
                if (double.TryParse(Console.ReadLine(), out double temp1))
                {
                    // temp1 now contains the parsed temperature
                    //5. Converting in a method convertTemp from Celsius to Fahrenheit
                    double tempResult = convertTemp(temp1);
                    Console.WriteLine($"Your result is: {tempResult} F");
                    Console.WriteLine("Thanks for comming!");
                    isEntering = false;
                }
                else
                {
                    // temp1 now dosen't contains the parsed temperature
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            //6. A method for converting temperature's value
           double convertTemp(double temp1)
            {
                return 1.8 * temp1 + 32.0;
            }
        
        }
    }
}


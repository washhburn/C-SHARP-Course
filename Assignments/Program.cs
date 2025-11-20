using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26___Exception_Handling__Try_Catch_
{
    internal class Program
    {
        //Task 1: Class Caclulator with method Divide
        class Calculator
        {
            public double Divide(int numerator, int denominator)
            {
                try
                {
                    int result = numerator / denominator;
                    return (double)numerator / denominator;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return 0.0;
                }
            }

            //Task 2: Method
            public int ParseInput(string input)
            {
                try
                {
                    int number = int.Parse(input);
                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error - input is invalid, you can only enter numbers.");
                    return -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error - the number entered is too large or too small.");
                    return -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                    return -1;
                }
            }
        }

        static void Main(string[] args)
        {
            //Task 4: Create Instance of Calculator
            Console.WriteLine("---- Calculator ----");
            Calculator calculator = new Calculator();

            Console.Write("Enter the numerator: ");
            string numeratorInput = Console.ReadLine();
            int numInput = calculator.ParseInput(numeratorInput);

            Console.Write("Enter the denominator: ");
            string denominatorInput = Console.ReadLine();
            int denInput = calculator.ParseInput(denominatorInput);

            if (numInput != -1 && denInput != -1)
            {
                double divisionResult = calculator.Divide(numInput, denInput);
                Console.WriteLine($"Result: {divisionResult}");
            }
            else
            {
                Console.WriteLine("Cannot perform division due to invalid input. Exiting program.");
            }

        }
    }
}

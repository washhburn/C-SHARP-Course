using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27___Functions
{
    internal class Program
    {
        //Task 1: Create class
        class MathOperations
        {
            //Task 2: Define methods
            //Task 2a: Addition
            public int Addition(int x, int y)
            {
                return x + y;
            }
            //Task 2b: Subtraction
            public int Subtraction(int x, int y)
            {
                return x - y;
            }
            //Task 2c: Multiplication
            public int Multiplication(int x, int y)
            {
                return x * y;
            }
            //Task 2d: Division
            public double Division(double x, double y)
            {
                try
                {
                   if (y == 0)
                        throw new DivideByZeroException("Error: Cannot divide by zero."); //Task 3d: Handle division by zero
                    return x / y;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
            //Task 2e: Power
            public double Power(double x, double y)
            {
                return Math.Pow(x, y);
            }
        }
        static void Main(string[] args)
        {
            //Task 3: Main method implementation
            //Task 3a: Instance
            MathOperations mathOps = new MathOperations();

            //Task 3b: User input
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Task 3c: Method calls and output
            Console.WriteLine("Results:");
            Console.WriteLine($"Addition: {mathOps.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {mathOps.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {mathOps.Multiplication(num1, num2)}");
            Console.WriteLine($"Division: {mathOps.Division(num1, num2)}");
            Console.WriteLine($"Power: {mathOps.Power(num1, num2)}");


        }
    }
}

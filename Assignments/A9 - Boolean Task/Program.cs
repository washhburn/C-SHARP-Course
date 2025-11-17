using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9___Boolean_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: definition of integers
            int num1 = 5;
            int num2 = 10;
            int num3 = 20;
            int num4 = num1;

            //Task 2: definition of boolean variable
            bool isTrue = true;

            //Task 3: boolean logical operations
            bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
            bool resultOr = isTrue || (num1 < num3 || num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine($"resultAnd = {resultAnd}");
            Console.WriteLine($"resultOr = {resultOr}");
            Console.WriteLine($"resultNot = {resultNot}");

            //Task 4: comparison operations
            bool isGreater = num1 > num3;
            bool isLess = num2 < num4;
            
            Console.WriteLine($"4a - num1 is greater than num3: {isGreater}");
            Console.WriteLine($"4b - num2 is less than num4: {isLess}");
            Console.WriteLine($"4c - num1 is equal to num4: {num1 == num4}");
            Console.WriteLine($"4d - num2 is not equal to num3: {num2 != num3}");

            //Task 5: define two boolean expressions
            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);

            //Task 6: print the results
            Console.WriteLine($"6 - Expression 1 is: {expression1}");
            Console.WriteLine($"6 - Expression 2 is: {expression2}");
            Console.ReadLine();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14___Array_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Define two integers
            int num = 7;
            int length = 5;

            //Task 2: Create an integer array
            int[] multiplicationArray = new int[length];

            //Task 3: Generate multiplication table
            for (int i = 0; i < length; i++)
            {
                multiplicationArray[i] = num * (i + 1);
            }

            //Task 5: Print final array
            Console.WriteLine($"Multiplication Table for {num}: ");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{num} x {i+1} = {multiplicationArray[i]}");
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19___Integer_Array_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Integer array 0-5
            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            //Task 5: Length of the array
            Console.WriteLine("The length of the array is " + numbers.Length);

            //Task 4: Call function
            int sum = SumOfNumbers(numbers);

            //Task 6: If statement to check if value > -1
            if (sum > -1)
            {
                Console.WriteLine($"The total is: {sum}.");
            }
            //Task 7: If statement to handle negative values
            else if (sum < 0)
            {
                Console.WriteLine("Cannot add up an empty tray.");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array.");
            }
        }
        //Task 2: SumOfNumbers function
        static int SumOfNumbers(int[] numArray)
        {
            int sum2 = 0;

            //Taslk 3: Calculation of sum of numbers in array
            foreach (int num in numArray)
            {
                sum2 += num;
            }
            return sum2;
        }
    }
}

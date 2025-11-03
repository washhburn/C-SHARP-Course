using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13_Odd_or_Even_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input prompt
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Check if number is divisible by 2 and display message accordingly

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }


        }
    }
}

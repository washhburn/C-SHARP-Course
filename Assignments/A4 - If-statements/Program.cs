using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4___IF_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF Statement
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age < 0 || age > 18) 
            { 
                Console.WriteLine("Invalid age entered.");

            }
            else if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }



        }
    }
}

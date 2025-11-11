using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18___Area_Calculation_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: User input

            Console.WriteLine("-- Area Calculation of a Triangle --");
            Console.Write("\nWidth of triangle: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height of triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());

            //Task 3: call function and print area of triangle
            int triangle = Formula(width, height);
            Console.WriteLine($"The area of the triangle is {triangle} units.");
        }

        //Task 2: function formula
        static int Formula(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}

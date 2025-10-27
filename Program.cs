using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt for user input
            Console.Write("Enter a value for how many times you wish to run the loop: ");
            int loopCount = Convert.ToInt32(Console.ReadLine());

            //Loop definition
            for (int i = 1; i <= loopCount; i++)
            {
                Console.WriteLine($"Loop iteration number: {i}");
            }
            //After loop has finished
            Console.WriteLine("The loop has finished.");

            Console.ReadLine();

        }
        
    }
}

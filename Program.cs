using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23___TryParse_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Integer
            string mainInput = "katt";

            //Task 2: Error with conversion
            //int num = Convert.ToInt32(mainInput);
            int mainResult;

            //Task 3: Try Catch-block

            try
            {
                mainResult = Convert.ToInt32(mainInput);
                Console.WriteLine($"Conversion succeeded: {mainResult}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Failed to convert");
            }

            //Task 4: Reflection
            //With Try Catch we can tell if conversion failed or succeeded by whether an error exception occur or not
            //In this casee the result gave "Failed to convert" so the code caught an exception
            //Try Catch is supposed to be used in situations where unexpected problems occur
            //Instead TryParse should be used in situations where it would be common for errors to occur

            //Task 5: Custom Parse function

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();


                if (int.TryParse(numInput, out int num))
                {
                    success = true;
                    Console.WriteLine("Conversion succeded: " + num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }
        }
    }
}

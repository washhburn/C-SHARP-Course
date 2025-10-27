using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8___Age_Verification_and_Control_Flow_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input for age
            Console.Write("Please enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            //Constant variable for legal age
            const int LegalAge = 18;

            //If Statement to check age
            if (age >= LegalAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are under the legal age.");
            }

            //While Loop
            int Counter = 1;
            string loopResult = "";

            while (Counter <= 5)
            {
                Console.WriteLine("Counter: " + Counter);
                loopResult += Counter + " ";
                Counter++;
            }
            //Switch statement baserat på Counter
            int switchValue = Counter - 1;
            string switchResult;

            switch (switchValue)
            {
                case 1: switchResult = "One.";
                    break;
                case 2: switchResult = "Two.";
                    break;
                case 3: switchResult = "Three.";
                    break;
                case 4: switchResult = "Four.";
                    break;
                case 5: switchResult = "Five.";
                    break;
                default: switchResult = "Invalid number";
                    break;

            }

            //Var-variable John och hälsning
            var name = "John";
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine($"The results of the loop is: {loopResult.Trim()}");
            Console.WriteLine($"The results of the switch statement is: " + switchResult);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt & conversion
            Console.Write("Enter Student's Grade From 0-5: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            //switch statement
            switch (grade) 
            {
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;  
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
                default: Console.WriteLine("Invalid Grade");
                    break;

            }
            Console.ReadLine();
        }
    }
}

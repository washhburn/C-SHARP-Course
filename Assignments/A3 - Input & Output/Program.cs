using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_Input_and_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();

        }
    }
}

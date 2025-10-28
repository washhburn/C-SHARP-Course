using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10___Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Define six integer variables

            int num1 = 3;
            int num2 = 12;
            int num3 = 21;
            int num4 = 5;
            int num5 = 36;
            int num6 = 159;

            //Task 2: Perform operations
            Console.WriteLine("2a: sum of num1 and num2: " + (num1 + num2));
            Console.WriteLine("2b: product of num3 and num4: " + (num3 * num4));
            Console.WriteLine("2c: remainder of num5 divided by num6: " + (num5 % num6));

            //Task 3: increment and decrement
            Console.WriteLine("Increment num6: " + (++num6));
            Console.WriteLine("Decrement num6: " + (--num6));

            //Task 4: assignment operators and results using num5
            Console.WriteLine($" num5 += 10: { (num5 += 10) }");
            Console.WriteLine($" num5 -= 5: { (num5 -= 5) }");
            Console.WriteLine($" num5 *= 2: { (num5 *= 2) }");
            Console.WriteLine($" num5 /= 4: { (num5 /= 4) }");
            Console.WriteLine($" num5 %= 3: { (num5 %= 3) }");

            Console.ReadLine();

        }
    }
}

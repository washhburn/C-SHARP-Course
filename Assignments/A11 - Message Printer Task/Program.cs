using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_Message_Printer_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Prompt user to enter message
            Console.WriteLine("Please enter the following message: \nC# is fun, I am going to code C# tomorrow.");
            Console.WriteLine();

            //Task 2: Print message in original order
            var message = Console.ReadLine();
            Console.WriteLine("\nTask 2 - original message: ");
            Console.WriteLine(message);

            //Task 3: Print message in reverse order
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            Console.WriteLine("\nTask 3 - reverse order: ");
            Console.WriteLine(new string(messageArray));
            Console.WriteLine();

            //Task 4: Print message from top to bottom
            Console.WriteLine("\nTask 4 - top to bottom: "); 
            foreach (char c in message)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            //Task 5: Print message from top to bottom in reverse order
            Console.WriteLine("\nTask 5 - top to bottom and reverse order: ");
            foreach (char c in messageArray)
            {
                Console.WriteLine(c);
            }
        }
    }
}

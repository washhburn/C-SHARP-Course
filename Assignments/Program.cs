using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12_Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Prompt the user to enter a password
            Console.Write("Please enter your password: ");
            string password1 = Console.ReadLine();

            //Task 2 - Prompt the user to re-enter the password for confirmation
            Console.Write("Please re-enter your password: ");
            string password2 = Console.ReadLine();

            //Task 3 & 4 - Check the passwords and display messages based on checks

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Please enter a password.");
            }
            else if (password1.Length < 6)
            {
                Console.WriteLine("Password must be at least 6 characters long.");
            }
            else if (password1 != password2)
            {
                Console.WriteLine("Passwords do not match.");
            }
            else
            {
                Console.WriteLine("Password match.");
            }
             
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16___Sort_Reverse_Remove_and_Find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Create integer array

            int[] numbers = new int[]
            {
                 45, 12, 78, 34, 89, 23
            };

            //Task 2: Print original array
            Console.WriteLine("Original array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Task 3: Sort array in ascending order
            Array.Sort(numbers);
            Console.WriteLine("\nArray in ascending order: ");
            foreach (int numAscend in numbers)
            {
                Console.WriteLine(numAscend);
            }

            //Task 4: Reverse array and print
            Array.Reverse(numbers);
            Console.WriteLine("\nArray in descending order: ");
            foreach (int numDescend in numbers) 
            { 
                Console.WriteLine(numDescend); 
            }

            //Task 5: Remove an element
            Array.Clear(numbers, 1, 1);
            Console.WriteLine("\nRemove element 78 from array: ");
            foreach (int numRemove in numbers)
            {
                Console.WriteLine(numRemove);
            }

            //Task 6: Find the index of number 34
            int position = Array.IndexOf(numbers, 34);
            if (position != -1)
            {
                Console.WriteLine($"\nNumber 34 was found at position {position + 1}.");
            }
            else
            {
                Console.WriteLine("\nNumber 34 was not found.");
            }

        }
    }
}

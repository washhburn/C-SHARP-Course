using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17___Dictionary_Case_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary with students' information, currently empty
            Dictionary<int, string> students = new Dictionary<int, string>();

            Console.WriteLine("===== Student Management Menu =====");
            while (true)
            {
                Console.WriteLine("\n1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                //Choice menu
                switch (choice)
                {
                    case 1: //Enter student information
                        Console.Write("Enter Student ID (number): ");
                        int newID = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string newName = Console.ReadLine();
                        students.Add(newID, newName);
                        Console.WriteLine($"\nStudent {newName} added successfully!");
                        break;

                    case 2: //Remove student information
                        Console.Write("Enter ID of Student to be Removed: ");
                        int idRemove = int.Parse(Console.ReadLine());
                        if (students.ContainsKey(idRemove))
                        {
                            students.Remove(idRemove);
                            Console.WriteLine($"\nStudent ID {idRemove} has been removed.");
                        }
                        else
                        {
                            Console.WriteLine($"\nError - Student ID {idRemove} could not be found in the dictionary.");
                        }
                        break;

                    case 3: //Display all students and their ID number
                        Console.WriteLine ("\nStudent ID and Student Name: ");
                        foreach (var studentsAndIDs in students) 
                        { 
                            Console.WriteLine($"ID: {studentsAndIDs.Key} - Name: {studentsAndIDs.Value}"); 
                        }
                        break;

                    case 4: //Exit
                        Console.WriteLine("Exiting Student Management Menu.");
                        return;

                    default: //In case of invalid input
                        Console.WriteLine("Invalid input, please try again!");
                        break;

                }
            }

        }
    }
}

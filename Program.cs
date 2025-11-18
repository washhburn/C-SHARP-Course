using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24___ClassFields
{
    //Task 1: Create a person
    class Person
    {
        //Task 2: Declare fields
        private string FirstName;
        private string LastName;
        private int Age;
        private int BirthYear;
        private string Nationality;

        //Task 3: Constructor
        public Person(string firstName, string lastName, int age, int birthYear, string nationality)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.BirthYear = birthYear;
            this.Nationality = nationality;
        }

        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public string GetLastName()
        {
            return this.FirstName;
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetBirthYear(int birthYear)
        {
            this.BirthYear = birthYear;
        }

        public int GetBirthYear()
        {
            return BirthYear;
        }

        public void SetNationality(string nationality)
        {
            this.Nationality = nationality;
        }

        public string GetNationality()
        {
            return Nationality;
        }

        public string ReturnDetails()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nBirth year: {BirthYear}\nNationality: {Nationality}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5: Create Person object
            Person person = new Person("Alex", "Carter", 21, 2004, "Canadian");

            //Task 6: Display person's information
            Console.WriteLine(person.ReturnDetails());

            
            //Task 7: Update the object using new information
            person.SetFirstName("Tim");
            person.SetLastName("Rivera");
            person.SetAge(30);
            person.SetBirthYear(1995);
            person.SetNationality("American");

            //Task 8: Print updated return details
            Console.WriteLine(person.ReturnDetails());
            
        }

    }
}

using System;


namespace A2ConversionInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define string variable
            string birthYearText = "1990";
            Console.WriteLine("If you are born in 1990,");

            //Konvertera text till heltal

            int birthYear = int.Parse(birthYearText);
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine("then you are " + age + "years old.");

        }
    }
}

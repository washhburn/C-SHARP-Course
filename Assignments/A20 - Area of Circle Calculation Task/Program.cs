using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20___Area_of_Circle_Calculation_Task
{
    //Task 1: Class Circle
    class Circle
    {
        //Task 2a: Property
        public double Radius;

        //Task 2b: Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        //Method to calculate perimeter
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        //Task 2c: Method to calculate area
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            */

            //Task 3: Create Circle instance and assign radius value
            double radius = 1.5;
            Circle circle = new Circle(radius);
            
            double perimeter = circle.CalculatePerimeter();
            double area = circle.CalculateArea();

            //Task 4: Print results
            Console.WriteLine($"The perimeter of the circle: {perimeter:F2}");
            Console.WriteLine($"The area of the circle: {area:F2}");
        }
    }
}

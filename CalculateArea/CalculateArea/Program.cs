using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "exit")
            {
                Menu();
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "triangle":
                        TriangleArea();
                        Console.WriteLine();
                        break;
                    case "square":
                        SquareArea();
                        Console.WriteLine();
                        break;
                    case "rectangle":
                        RectangleArea();
                        Console.WriteLine();
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("Please select the shape for which you want to calculate the area: ");
            Console.WriteLine("Triangle");
            Console.WriteLine("Square");
            Console.WriteLine("Rectangle");
            Console.WriteLine("'exit' to exit the program");

        }

        static void TriangleArea()
        {
            Console.WriteLine("Please enter the base of the triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of the triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * b * h;
            Console.WriteLine("The area of the triangle is: " + area);
        }

        static void SquareArea()
        {
            Console.WriteLine("Please enter the length of the side of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("The area of the square is: " + area);
        }

        static void RectangleArea()
        {
            Console.WriteLine("Please enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = length * width;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}

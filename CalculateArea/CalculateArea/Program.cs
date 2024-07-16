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
            int input = 0;

            while (input != 5)
            {
                Menu();
                input = Convert.ToInt32(Console.ReadLine());

                Shape shape = null;

                switch (input)
                {
                    case 1:
                        shape = new Circle();
                        Console.WriteLine();
                        break;
                    case 2:
                        shape = new Triangle();
                        Console.WriteLine();
                        break;
                    case 3:
                        shape = new Square();
                        Console.WriteLine();
                        break;
                    case 4:
                        shape = new Rectangle();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                shape.CalculateArea();
                Console.WriteLine();
            }
        }

        abstract class Shape
        {
            private string _id;
            private string _name;
            private string _color;

            public abstract void CalculateArea();
        }

        class Circle : Shape
        {
            public double radius;

            public override void CalculateArea()
            {
                Console.WriteLine("Please enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;
                Console.WriteLine("The area of the circle is: " + area);
            }
        }

        class Square : Shape
        {
            public double side;

            public override void CalculateArea()
            {
                Console.WriteLine("Please enter the length of the side of the square: ");
                side = Convert.ToDouble(Console.ReadLine());

                double area = side * side;
                Console.WriteLine("The area of the square is: " + area);
            }
        }

        class Rectangle : Shape
        {
            public double length;
            public double width;

            public override void CalculateArea()
            {
                Console.WriteLine("Please enter the length of the rectangle: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the width of the rectangle: ");
                width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                Console.WriteLine("The area of the rectangle is: " + area);
            }
        }

        class Triangle : Shape
        {
            public double baseSide;
            public double height;

            public override void CalculateArea()
            {
                Console.WriteLine("Please enter the base of the triangle: ");
                baseSide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the height of the triangle: ");
                height = Convert.ToDouble(Console.ReadLine());

                double area = 0.5 * baseSide * height;
                Console.WriteLine("The area of the triangle is: " + area);
            }
        }

        static void Menu()
        {
            Console.WriteLine("Please select the number of the shape for which you want to calculate the area: ");
            Console.WriteLine("1: Circle");
            Console.WriteLine("2: Triangle");
            Console.WriteLine("3: Square");
            Console.WriteLine("4: Rectangle");
            Console.WriteLine("5: Exit");
            Console.WriteLine();

        }
    }
}

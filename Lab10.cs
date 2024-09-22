using System;

namespace DotnetLBeena
{
    internal class Lab10
    {
        class Shape
        {
            public double Length { get; set; }
            public double Breadth { get; set; }

            public Shape()
            {
                Length = 0;
                Breadth = 0;
            }

            public Shape(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(double length, double breadth) : base(length, breadth)
            {
            }

            public double CalculateArea()
            {
                return Length * Breadth;
            }

            public void Display()
            {
                Console.WriteLine($"Length: {Length}");
                Console.WriteLine($"Breadth: {Breadth}");
                Console.WriteLine($"Area of Rectangle: {CalculateArea()}");
            }
        }

        class Program22
        {
            /* static void Main()
             {
                Rectangle rect = new Rectangle(15, 29);

                 rect.Display();
                 Console.ReadKey();
             } */
        }

    }
}

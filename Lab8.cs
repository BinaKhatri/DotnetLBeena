using System;
namespace DotnetLBeena
{
    internal class Lab8 { 
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public void Display()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y})");
        }
    }

    class Program123
    {
        /* static void Main()
         {

             Point point1 = new Point(3, 4);
             Point point2 = new Point(5, 7);


             Console.WriteLine("Original Points:");
             point1.Display();
             point2.Display();


             Point result = point1 + point2;


             Console.WriteLine("\nAfter Addition:");
             result.Display();
             Console.ReadKey();
         }*/
    }

}
}

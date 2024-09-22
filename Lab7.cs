using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLBeena
{
    internal class Lab7Number
    {
        public class Number
        {
            public int Value { get; set; }
            public Number(int value)
            {
                Value = value;
            }
            public static Number operator -(Number n)
            {
                return new Number(-n.Value);
            }
            public static Number operator ++(Number n)
            {
                n.Value += 1;
                return n;
            }
            public void Display()
            {
                Console.WriteLine("Value: " + Value);
            }
        }
        class Program
        {
          /*  static void Main(string[] args)
            {
                Number num = new Number(5);
                Console.WriteLine("Original value:");
                num.Display();
                Number negatedNum = -num;
                Console.WriteLine("\nAfter applying unary minus (-):");
                negatedNum.Display();
                ++num;
                Console.WriteLine("\nAfter applying increment (++) operator:");
                num.Display();
            }
          */
        }
    }
}

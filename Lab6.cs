using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLBeena
{
    internal class Lab6
    {
        public class Person
        {
            public string Name;
            public int Age;
            public static string Species = "Human";
            public Person()
            {
                Name = "Unknown";
                Age = 0;
                Console.WriteLine("Default constructor called.");
            }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Parameterized constructor called.");
            }
            public Person(Person person)
            {
                Name = person.Name;
                Age = person.Age;
                Console.WriteLine("Copy constructor called.");
            }
            static Person()
            {
                Console.WriteLine("Static constructor called. Species: " + Species);
            }
            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }
        class Program
        {
          /*  static void Main(string[] args)
            {
                Person person1 = new Person();
                person1.Display();

                Console.WriteLine();
                Person person2 = new Person("Beena", 21);
                person2.Display();

                Console.WriteLine();
                Person person3 = new Person(person2);
                person3.Display();
            } */
        }
    }
}


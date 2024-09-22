using System;

namespace PartialClassExample
{
    public partial class Person
    {
        public int Age;

        public void DisplayAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Program
    {
        /* static void Main(string[] args)
         {

             Person person = new Person("Beena", "Khatri");
             person.Age = 21;


             person.DisplayFullName();
             person.DisplayAge();

             Console.ReadLine();         }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLBeena
{
    internal class Lab5
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The dog barks.");
            }
        }
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The cat meows.");
            }
        }
        class Program
        {
          /*  static void Main(string[] args)
            {
                Animal myDog = new Dog();
                Animal myCat = new Cat();
                myDog.MakeSound();
                myCat.MakeSound();
                Animal genericAnimal = new Animal();
                genericAnimal.MakeSound();
            } */
        }
    }
}
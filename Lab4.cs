using System;

namespace InheritanceDemo
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }

    public class GermanShepherd : Dog
    {
        public void Guard()
        {
            Console.WriteLine($"{Name} is guarding the house.");
        }
    }

    class Program
    {
      /*  static void Main(string[] args)
        {
            
            Dog dog = new Dog();
            dog.Name = "Fiyona";
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

           
            Cat cat = new Cat();
            cat.Name = "Kitty";
            cat.Eat();
            cat.Meow();

            Console.WriteLine();

            GermanShepherd germanShepherd = new GermanShepherd();
            germanShepherd.Name = "Rex";
            germanShepherd.Eat();
            germanShepherd.Bark(); 
            germanShepherd.Guard(); 

            Console.WriteLine();
            Console.WriteLine("Hierarchical Inheritance: Both Dog and Cat inherit from Animal class.");
        } */
    }
}

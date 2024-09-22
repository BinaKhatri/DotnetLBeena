using System;
namespace DotnetLBeena
{
    internal class Lab9
    {
        class Person1
{
    private string name;
    private int age;
    private string secret;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
    }

    public string Secret
    {
        set { secret = value; }
    }

    
    public string Address { get; set; }

  
    public Person1(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
    }
}

class Program1234
{
   /* static void Main()
    {

        Person1 person = new Person1("Pratima", 25);

        person.Name = "Beena Khatri";  // Setting name
        Console.WriteLine($"Updated Name: {person.Name}");  
        Console.WriteLine($"Age: {person.Age}");

        person.Secret = "This is a secret message."; 
       
        person.Address = "123 Main St";
        person.DisplayInfo();
        Console.ReadKey();
    }*/
}

    }
}

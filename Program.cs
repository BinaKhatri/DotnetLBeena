using System;
class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
    public Employee(string name, string email, decimal salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Salary: $" + Salary);
    }
}
class Program
{
  /*  static void Main(string[] args)
    {
        Employee employee = new Employee("Beena Khatri", "khatribeena984@gmail.com", 100000);
        employee.DisplayEmployeeDetails();

        Console.ReadLine();
    } */
}
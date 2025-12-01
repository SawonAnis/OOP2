using System;
namespace ConstructorEx
{
  class Employee
  {
    public int Id, Age;
    public string Address, Name;
    public bool IsPermanent;

    public Employee(int id, int age, string name, string address, bool isPermanent)
    {
      Id = id;
      Name = name;
      Age = age;
      Address = address;
      IsPermanent = isPermanent;
    }
    public void Display()
    {
      Console.WriteLine("Id: " + Id);
      Console.WriteLine("Name: " + Name);
      Console.WriteLine("Age: " + Age);
      Console.WriteLine("Address: " + Address);
      Console.WriteLine("IsPermanent: " + IsPermanent);
    }
  }
  
  class Program
  {
    static void Main(string[] args)
    {
      Employee emp = new Employee(101, 25, "John Doe", "123 Main St", true);
      emp.Display();
    }
  }
}
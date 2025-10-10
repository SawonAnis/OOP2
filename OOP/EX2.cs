using System;

class Person
{
  public string Name;
  public int BirthYear;

  public int GetAge()
  {
    return DateTime.Now.Year - BirthYear;
  }
}

class Program
{
  public static void Main(string[] args)
  {
    Person p = new Person();
    p.Name = "Alice";
    p.BirthYear = 2000;

    Console.WriteLine($"{p.Name} is {p.GetAge()} years old.");
  }
}
using System;

namespace ParameterizedConDemo
{
  class Student
  {
    int roll;
    string name;

    public Student(int roll, string name)
    {
      this.roll = roll;
      this.name = name;
      Console.WriteLine("Roll: " + roll);
      Console.WriteLine("Name: " + name);
    }

  }

  class Program
  {
    public static void Main(string[] args)
    {
      Student student = new Student(47, "Sawon");
    }
  }

}
using System;

namespace DefaultConDemo
{
  class Student
  {
    int roll;
    string name;

    public Student()
    {
      Console.WriteLine("Default Constructor Called");
    }
    public static void Main(string[] args)
    {
      Student student = new Student();
      Console.WriteLine(student.roll);
        Console.WriteLine(student.name);
    }
  }
}
using System;

namespace InheritanceEx
{
  class A
  {
    public void Display()
    {
      Console.WriteLine("Class A Display method");
    }
    public void Display2()
    {
      Console.WriteLine("Class A Display2 method");
    }

  }

  class B : A
  {
    public static void Main(string[] args)
    {
      B obj = new B();

      obj.Display();
      obj.Display2();
    
    }
  }
}
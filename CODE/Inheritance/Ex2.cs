using System;

namespace Ex2
{
  class A
  {
    public A(int number)
    {
      Console.WriteLine($"Class A Constructor is called: {number}");
    }
    public void Method1()
    {
      Console.WriteLine("Method 1");
    }
    public void Method2()
    {
      Console.WriteLine("Method 2");
    }
  }

  class B : A
  {
    public B(int num) : base(num)
    {
      Console.WriteLine("Class B Constructor is Called");
    }
    public void Method3()
    {
      Console.WriteLine("Method 3");
    }
    public static void Main(string[] args)
    {
      B obj1 = new B(100);
      B obj2 = new B(200);
      B obj3 = new B(300);
          }
  }
}
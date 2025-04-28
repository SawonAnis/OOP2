using System;
namespace CsharpInterface
{

  interface IPolygon
  {
    void calculateArea(int a, int b);
  }

  interface IColor
  {
    void getColor();
  }

  class Rectangle : IPolygon, IColor
  {
    public void calculateArea(int a, int b)
    {
      int area = a * b;
      Console.WriteLine("Area of Rectangle: " + area);
    }
       public void getColor() {

      Console.WriteLine("Green Rectangle");
            
    }
  }



  class Program
  {
    public static void Main(string[] args)
    {
      Rectangle r1 = new Rectangle();
      r1.calculateArea(40, 50);
      r1.getColor();
    }
  }
}
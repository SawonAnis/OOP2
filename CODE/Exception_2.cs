using System;
namespace ExceptionHandlingDemo
{
  class Program
  {
    public static void Main(string[] args)
    {
      int num1, num2, result;

      try
      {
        Console.WriteLine("Enter First Number:");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        num2 = int.Parse(Console.ReadLine());

        result = num1 / num2;
        Console.WriteLine("Result: " + result);
      }

        catch (DivideByZeroException e)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
      
    }
  }
}
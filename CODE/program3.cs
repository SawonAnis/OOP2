
/* Write a C# program that prompts the user to input two numbers 
and divides them. Handle an exception when the user enters non-numeric 
values. */


using System;

namespace prac3
{

  class Program
  {

    public static void Main(string[] args)
    {

      try
      {
        Console.WriteLine("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int dev = num1 / num2;
        Console.WriteLine(dev);
      }

      catch (FormatException)
      {

        Console.WriteLine("Error: Non-numeric value entered.");

      }
      catch (Exception ex)
      {
        Console.WriteLine("An error occurred: " + ex.Message);
      }

    }

  }
}





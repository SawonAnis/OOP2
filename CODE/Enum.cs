using System;
namespace EnumApplication
{

  enum Days
  {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    offday=500
  };
  class Program
  {
    public static void Main(string[] args)
    {
      Days day = Days.Friday;
      int day1 = (int)Days.offday;
      Console.WriteLine(day);
   Console.WriteLine(day1);
    }
  }
}
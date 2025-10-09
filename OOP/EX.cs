using System;

class Car
{
  public string Brand { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }

  public void DisplayInfo()
  {
    Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
  }

class Program
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.Brand = "Toyota";
      myCar.Model = "Corolla";
      myCar.Year = 2020;

      myCar.DisplayInfo();
    }
  }
}
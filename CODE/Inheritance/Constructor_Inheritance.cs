using System;

namespace ConInheritanceDemo
{
    class Vehicle
    {
        public string Brand;
        public Vehicle(string brand)
        {
            Brand = brand;
        }
    }
    class Car : Vehicle
    {
        public string Model;
        public Car(string brand,string model) : base(brand)
        {
            Model = model;
        }
    }
  class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla");
            Console.WriteLine("Brand: " + myCar.Brand);
            Console.WriteLine("Model: " + myCar.Model);
        }
    }
}
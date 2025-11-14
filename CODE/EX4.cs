using System;
namespace DataTypeEx
{
  class Program
  {
    public static void Main(string[] args)
    {
      Int16 a = 10;
      Int32 b = 20;
      Int64 c = 30;

      Console.WriteLine($"Int16 Min Value: {Int16.MinValue}, Max Value: {Int16.MaxValue} ");
      Console.WriteLine($"Int32 Min Value: {Int32.MinValue}, Max Value: {Int32.MaxValue} ");
      Console.WriteLine($"Int64 Min Value: {Int64.MinValue}, Max Value: {Int64.MaxValue} ");

      Console.WriteLine($"Int16 Size:{sizeof(Int16)} Byte");
      Console.WriteLine($"Int32 Size:{sizeof(Int32)} Byte");
      Console.WriteLine($"Int64 Size:{sizeof(Int64)} Byte");  

        float x = 1.78986380830029492956829698978655434342477f; 
            double y = 1.78986380830029492956829698978655434342477; 
            decimal z = 1.78986380830029492956829698978655434342477m; 
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

       
    }
  }
}

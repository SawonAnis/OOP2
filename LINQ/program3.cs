using System;
using System.Linq;
using System.Collections.Generic;

namespace consoleapp{
 class Program{

public static void Main(string[] args)
{
      int[] num = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };

      int minimumNum = num.Min();
      int maximumNum = num.Max();

      Console.WriteLine("The Minimum Number is {0}", minimumNum);  
        Console.WriteLine("The Maximum Number is {0}", maximumNum);  
  
            Console.ReadLine();  
} 


}





}
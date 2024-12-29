using System;
using System.Linq;
using System.Collections.Generic;

namespace Consoleapp{

class Program {
   public static void Main(string[] args)
{
      List<int> integerList = new List<int>(){
    10,20,30,40,50,60,70,80,90,100
  };

      var MethodSyntax = integerList.Where(obj =>obj > 30).ToList();
foreach(var item in MethodSyntax){
        Console.WriteLine(item);
}
      
}




























}





















}
using System.Collections.Generic;
using System.Linq;

class PracLinq
{

   static public void Main()
   {

      List<string> list = new List<string>()
      {

"Hi,I'm Sawon",
"Welcome to programming world",
"Sawon is a bad boy"

 };
      var s = from L in list
              where L.Contains("Sawon")
              select L;


      foreach (var L in s)
      {
         Console.WriteLine(L);
      }

   }
}
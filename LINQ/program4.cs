using System;  
using System.Collections.Generic;  
using System.Linq;  

namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
 
            string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };  
 
            IEnumerable<string> result = countries.Take(3);  
            foreach (string s in result)  
            {  
                Console.WriteLine(s);  
            }  
                Console.ReadLine();  
        }  
    }  
}  
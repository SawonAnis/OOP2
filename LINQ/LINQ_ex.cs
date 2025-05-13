using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
10,20,30,40,50,60,70,80,90,100
            };

            var QueryList = integerList.Where(obj => obj > 50).ToList();
            foreach (var item in QueryList)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
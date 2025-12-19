using System;
using System.Collections.Generic;
namespace CollectionProject
{
  class DictionaryCollection
  {
    public static void Main(string[] args)
    {
      Dictionary<string, object> dt = new Dictionary<string, object>();
      dt.Add("Eid", 2020);
      dt.Add("Name", "John Doe");
      dt.Add("Salary", 50000);
      dt.Add("IsActive", true);

        foreach(string key in dt.Keys)
        {
            Console.WriteLine("Key: " + key + ", Value: " + dt[key]);
        }
      }
  }
}
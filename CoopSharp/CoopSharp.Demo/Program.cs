using System;
using System.Linq;

namespace CoopSharp.Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      var coopClient = new CoopClientFactory().Create();

      var restaurants = coopClient.GetRestaurants().Result;

      Console.Out.WriteLine(restaurants.Results.Count);

      var menus = coopClient.GetTodaysMenus(2042).Result;
      Console.WriteLine($"{menus.Results.First().Title}, {menus.Results.First().Price}");

      Console.ReadLine();
    }
  }
}

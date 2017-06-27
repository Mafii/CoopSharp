using System;
using System.Linq;
using System.Threading.Tasks;

using CoopSharp.Demo.Common;
using CoopSharp.Models;

namespace CoopSharp.Demo
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      AsyncMain().GetAwaiter().GetResult();
    }

    private static async Task AsyncMain()
    {
      var coopClient = new CoopClientFactory().Create();
      var restaurants = await coopClient.GetRestaurants();
      var menus = await coopClient.GetTodaysMenus(2042);
      var restaurants2 = await coopClient.GetRestaurants(new Coordinates(47.48072139766479, 8.20896424100014));

      Console.Out.WriteLine(restaurants.Results.Count);
      Console.WriteLine($"{menus.Results.First().Title}, {menus.Results.First().Price}");

      foreach (Restaurant restaurant in restaurants2.Results)
      {
        Console.WriteLine($"{restaurant.Id} {restaurant.Name}");
      }

      if (Environment.OSVersion.IsWindows()) { Console.ReadLine(); }
    }
  }
}

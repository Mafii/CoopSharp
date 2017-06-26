using System;

namespace CoopSharp.Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      var coopClient = new CoopClientFactory().Create();

      var restaurants = coopClient.GetRestaurants().Result;

      Console.Out.WriteLine(restaurants.Results.Count);

      Console.WriteLine("Not yet implemented!");
      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
      Console.ReadLine();
    }
  }
}

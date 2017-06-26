using System.Collections.Generic;

namespace CoopSharp.Models
{
  public class RestaurantsResult
  {
    public RestaurantsResult(IList<Restaurant> results)
    {
      Results = results;
    }

    public IList<Restaurant> Results { get; }
  }
}
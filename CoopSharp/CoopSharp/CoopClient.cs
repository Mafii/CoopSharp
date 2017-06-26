using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using CoopSharp.Common;
using CoopSharp.Models;
using Newtonsoft.Json;

namespace CoopSharp
{
  internal class CoopClient : ICoopClient
  {
    private readonly IRequester requester;

    internal CoopClient(IRequester requester)
    {
      this.requester = requester;
    }

    public Task<RestaurantsResult> GetRestaurants() => Deserialize<RestaurantsResult>(requester.Get("/locations"));

    public Task<RestaurantsResult> GetRestaurants(Coordinates coordinates, int? limit = null)
    {
      var longitude = KeyValuePair.Create(nameof(Coordinates.Latitude).ToLowerInvariant(), coordinates.Latitude.ToString("F"));
      var latitude = KeyValuePair.Create(nameof(Coordinates.Longitude).ToLowerInvariant(), coordinates.Longitude.ToString("F"));

      var parameters = new[] { longitude, latitude }.ToList();
      if (limit.HasValue)
      {
        parameters.Add(KeyValuePair.Create(nameof(limit), limit.Value.ToString()));
      }

      var result = requester.Get("/locations", parameters.ToImmutableDictionary());

      return Deserialize<RestaurantsResult>(result);
    }

    public Task<RestaurantsResult> GetRestaurants(string query, int? limit = null)
    {
      var parameters = new[] { KeyValuePair.Create(nameof(query), query) }.ToList();

      if (limit.HasValue)
      {
        parameters.Add(KeyValuePair.Create(nameof(limit).ToLowerInvariant(), limit.Value.ToString()));
      }

      var result = requester.Get("/locations", parameters.ToImmutableDictionary());

      return Deserialize<RestaurantsResult>(result);
    }

    public Task<Restaurant> GetRestaurant(int restaurantId)
    {
      var result = requester.Get($"/locations/{restaurantId}");

      return Deserialize<Restaurant>(result);
    }

    public Task<MenusResult> GetMenus(int restaurantId)
    {
      var result = requester.Get($"/locations/{restaurantId}/menus");

      return Deserialize<MenusResult>(result);
    }

    public Task<MenusResult> GetMenus(Restaurant restaurant) => GetMenus(restaurant.Id);

    public Task<MenusResult> GetTodaysMenus(int restaurantId)
    {
      var result = requester.Get($"/locations/{restaurantId}/menus/today");

      return Deserialize<MenusResult>(result);
    }

    public Task<MenusResult> GetTodaysMenus(Restaurant restaurant) => GetTodaysMenus(restaurant.Id);

    public Task<MenusResult> GetMenus(int restaurantId, DateTime day)
    {
      var result = requester.Get($"/locations/{restaurantId}/menus/{day.ToUnixTimeStamp()}");

      return Deserialize<MenusResult>(result);
    }

    public Task<MenusResult> GetMenus(Restaurant restaurant, DateTime day) => GetMenus(restaurant.Id, day);

    private static Task<T> Deserialize<T>(Task<string> jsonTask)
    {
      return Task.Run(async () => JsonConvert.DeserializeObject<T>(await jsonTask));
    }
  }
}

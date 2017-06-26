using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoopSharp.Models;

namespace CoopSharp
{
  /// <summary>
  /// Represents https://github.com/STJEREM/coop/blob/development/README.md
  /// </summary>
  public interface ICoopClient
  {
    Task<RestaurantsResult> GetRestaurants();

    Task<RestaurantsResult> GetRestaurants(Coordinates coordinates, int? limit = null);

    Task<RestaurantsResult> GetRestaurants(string query, int? limit = null);

    Task<Restaurant> GetRestaurant(int restaurantId);

    Task<IList<Menu>> GetMenus(int restaurantId);

    Task<IList<Menu>> GetMenus(Restaurant restaurant);

    Task<IList<Menu>> GetTodaysMenus(int restaurantId);

    Task<IList<Menu>> GetTodaysMenus(Restaurant restaurant);

    Task<IList<Menu>> GetMenus(int restaurantId, DateTime day);

    Task<IList<Menu>> GetMenus(Restaurant restaurant, DateTime day);
  }
}

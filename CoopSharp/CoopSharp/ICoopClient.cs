using System;
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

    Task<MenusResult> GetMenus(int restaurantId);

    Task<MenusResult> GetMenus(Restaurant restaurant);

    Task<MenusResult> GetTodaysMenus(int restaurantId);

    Task<MenusResult> GetTodaysMenus(Restaurant restaurant);

    Task<MenusResult> GetMenus(int restaurantId, DateTime day);

    Task<MenusResult> GetMenus(Restaurant restaurant, DateTime day);
  }
}

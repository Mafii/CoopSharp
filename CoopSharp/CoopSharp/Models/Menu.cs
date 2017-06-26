using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CoopSharp.Models
{
  public class Menu
  {
    public Menu(string title, IReadOnlyList<string> contents, decimal price, DateTime date)
    {
      Title = title;
      Contents = contents;
      Price = price;
      Date = date;
    }

    public string Title { get; }

    [JsonProperty("menu")]
    public IReadOnlyList<string> Contents { get; }

    public decimal Price { get; }

    /// <summary>
    /// Represents the APIs timestamp (always midnight)
    /// </summary>
    public DateTime Date { get; }
  }
}
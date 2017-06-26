using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CoopSharp.Models
{
  public class Location
  {
    public Location(Coordinates coordinates, Address address)
    {
      Coordinates = coordinates;
      Address = address;
    }

    [JsonConstructor]
    public Location(double[] coordinates, Address address)
    {
      if (coordinates.Length != 2)
      {
        throw new ArgumentOutOfRangeException(nameof(coordinates), "There should be exactly two coordinates in the object");
      }

      Coordinates = new Coordinates(coordinates[0], coordinates[1]);
      Address = address;
    }

    public Coordinates Coordinates { get; }

    public Address Address { get; }
  }
}
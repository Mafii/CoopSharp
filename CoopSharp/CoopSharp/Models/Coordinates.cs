using System.Diagnostics;

namespace CoopSharp.Models
{
  /// <summary>
  /// Coordinates representing GeoJsons geometry coordinates property:
  ///  "geometry": {
  ///  "type": "Point",
  ///  "coordinates": [125.6, 10.1]
  /// }
  /// </summary>
  public class Coordinates
  {
    public Coordinates(double longitude, double latitude)
    {
      Longitude = longitude;
      Latitude = latitude;
    }

    public double Longitude { get; }

    public double Latitude { get; }
  }
}
